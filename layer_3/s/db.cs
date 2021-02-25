using layer_0.cell;
using MongoDB.Driver;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace layer_3.s
{
    class db<T> : s_db<T> where T : m_id
    {
        public IMongoCollection<T> coll { get; }
        internal db(IMongoCollection<T> coll) => this.coll = coll;
        public async Task<T> get(string id)
        {
            return await (await coll.FindAsync(i => i.id == id)).FirstOrDefaultAsync();
        }
        public async Task<T> get(Expression<Func<T, bool>> filter)
        {
            return await (await coll.FindAsync(filter)).FirstOrDefaultAsync();
        }

        private bool mm(T arg)
        {
            throw new NotImplementedException();
        }

        public async Task upsert(T val)
        {
            await coll.ReplaceOneAsync(i => i.id == val.id, val, new ReplaceOptions() { IsUpsert = true });
        }
    }
}