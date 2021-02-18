using MongoDB.Driver;

namespace layer_0
{
    public interface s_db
    {
        IMongoCollection<T> all<T>();
        IMongoCollection<T> user<T>(string xid, string userid);
        IMongoCollection<T> x<T>(string xid);
    }
}
