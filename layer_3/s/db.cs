using layer_0.cell;
using layer_3.m;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace layer_3.s
{
    class db<T> : s_db<T> where T : m_id
    {
        bool is_sync = false;
        private readonly string xid;
        string userid;
        IMongoCollection<s_history> history;
        internal db(string xid, string userid)
        {
            this.xid = xid;
            this.userid = userid;
            Type type = typeof(m_sync);
            is_sync = type.IsAssignableFrom(typeof(T));
            string collection_name;
            if (userid == null)
            {
                collection_name = "x_" + typeof(T).Name;
                this.userid = xid;
            }
            else
                collection_name = userid + "_" + typeof(T).Name;
            coll = a.mongo.GetDatabase(xid).GetCollection<T>(collection_name);
            history = a.mongo.GetDatabase(xid).GetCollection<s_history>(collection_name + "_h");
        }
        public IMongoCollection<T> coll { get; }
        public async Task<T> get(string id)
        {
            return await (await coll.FindAsync(i => i.id == id)).FirstOrDefaultAsync();
        }
        public async Task<T> get(Expression<Func<T, bool>> filter)
        {
            return await (await coll.FindAsync(filter)).FirstOrDefaultAsync();
        }
        public async Task upsert(T val)
        {
            await coll.ReplaceOneAsync(i => i.id == val.id, val, new ReplaceOptions() { IsUpsert = true });
            if (is_sync)
            {
                s_history document = new s_history() { id = val.id, add = true, time = DateTime.Now };
                await history.ReplaceOneAsync(i => i.id == val.id, document, new ReplaceOptions() { IsUpsert = true });
                notify.send(userid);
            }
        }
        public async Task<y_sync.o> get_history(DateTime time)
        {
            var all = await (await history.FindAsync(i => i.time > time)).ToListAsync();
            var rt = new y_sync.o()
            {
                deleted = all.Where(i => !i.add).Select(i => i.id).ToArray(),
                time = all.Count == 0 ? time : all.Max(i => i.time)
            };
            var updated_id = all.Where(i => i.add).Select(i => i.id).ToArray();
            if (updated_id.Length != 0)
            {
                var updated = await (await coll.FindAsync(i => updated_id.Contains(i.id))).ToListAsync();
                rt.updated = updated.Select(i => JsonConvert.SerializeObject(i)).ToArray();
            }
            return rt;
        }
        public async Task delete(string id)
        {
            await coll.DeleteOneAsync(i => i.id == id);
            if (is_sync)
            {
                s_history document = new s_history() { id = id, add = false, time = DateTime.Now };
                await history.ReplaceOneAsync(i => i.id == id, document);
                notify.send(userid);
            }
        }
        public async Task<bool> any(Expression<Func<T, bool>> filter)
        {
            return await (await coll.FindAsync(filter)).AnyAsync();
        }
        public async Task delete_many(string[] ids) => await coll.DeleteManyAsync(i => ids.Contains(i.id));
    }
}