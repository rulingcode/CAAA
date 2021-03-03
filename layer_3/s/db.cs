using layer_0.cell;
using MongoDB.Driver;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace layer_3.s
{
    class db<T> : s_db<T> where T : m_id
    {
        bool is_sync = false;
        private readonly string xid;
        private readonly string userid;

        class item : m_id
        {
            public DateTime time { get; set; }
            public bool add { get; set; }
        }
        public IMongoCollection<T> coll { get; }
        IMongoCollection<item> history { get; }
        internal db(string xid, string userid)
        {
            this.xid = xid;
            this.userid = userid;
            Type type = typeof(m_sync);
            is_sync = type.IsAssignableFrom(typeof(T));
            var name = userid == null ? "x_" + typeof(T).Name : "u_" + userid + "_" + typeof(T).Name;
            coll = a.s_db.GetDatabase(xid).GetCollection<T>(name);
            history = a.s_db.GetDatabase(xid).GetCollection<item>(name + "_h");
            this.coll = coll;
        }

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
                item document = new item() { id = val.id, add = true, time = DateTime.Now };
                await history.ReplaceOneAsync(i => i.id == val.id, document);
            }
        }
        public async Task delete(string id)
        {
            await coll.DeleteOneAsync(i => i.id == id);
            if (is_sync)
            {
                item document = new item() { id = id, add = false, time = DateTime.Now };
                await history.ReplaceOneAsync(i => i.id == id, document);
            }
        }
        public async Task<bool> any(Expression<Func<T, bool>> filter)
        {
            return await (await coll.FindAsync(filter)).AnyAsync();
        }
    }
}