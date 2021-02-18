using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3
{
    public interface s_db
    {
        IMongoCollection<T> all<T>();
        IMongoCollection<T> user<T>(string xid, string userid);
        IMongoCollection<T> x<T>(string xid);
    }
    class z_db : s_db
    {
        MongoClient client = new MongoClient();
        public IMongoCollection<T> x<T>(string xid)
        {
            return client.GetDatabase(xid).GetCollection<T>("x_" + typeof(T).Name);
        }
        public IMongoCollection<T> user<T>(string xid, string userid)
        {
            return client.GetDatabase(xid).GetCollection<T>("u_" + userid + "_" + typeof(T).Name);
        }
        public IMongoCollection<T> all<T>()
        {
            return client.GetDatabase("all").GetCollection<T>(typeof(T).Name);
        }
    }
}
