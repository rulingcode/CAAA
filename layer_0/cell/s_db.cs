using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace layer_0.cell
{
    public interface s_db<T> where T : m_id
    {
        IMongoCollection<T> coll { get; }
        Task upsert(T val);
        Task delete(string id);
        Task<T> get(string id);
        Task<T> get(Expression<Func<T, bool>> filter);
        Task<bool> any(Expression<Func<T, bool>> filter);
        Task<y_sync.o> get_history(DateTime time);
        Task delete_many(string[] ids);
    }
}