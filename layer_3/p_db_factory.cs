using layer_0;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3
{
    class p_db<T> : s_db<T> where T : m_id
    {
        internal p_db(IMongoCollection<T> coll) => db = coll;
        public IMongoCollection<T> db { get; }
        public async Task<T> get(string id) => await (await db.FindAsync(i => i.id == id)).FirstOrDefaultAsync();
        public async Task upsert(T val)
        {
            await db.ReplaceOneAsync(i => i.id == val.id, val, new ReplaceOptions() { IsUpsert = true });
        }
    }
    class p_db_factory
    {
        MongoClient client = new MongoClient();
        public s_db<T> x<T>(string xid) where T : m_id
        {
            return new p_db<T>(client.GetDatabase(xid).GetCollection<T>("x_" + typeof(T).Name));
        }
        public s_db<T> user<T>(string xid, string userid) where T : m_id
        {
            return new p_db<T>(client.GetDatabase(xid).GetCollection<T>("u_" + userid + "_" + typeof(T).Name));
        }
        public s_db<T> all<T>() where T : m_id
        {
            return new p_db<T>(client.GetDatabase("all").GetCollection<T>(typeof(T).Name));
        }
    }
}
