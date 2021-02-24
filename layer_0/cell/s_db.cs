using System.Threading.Tasks;
using MongoDB.Driver;

namespace layer_0.cell
{
    public interface s_db<T> where T : m_id
    {
        IMongoCollection<T> coll { get; }
        Task upsert(T val);
        Task<T> get(string id);
    }
}