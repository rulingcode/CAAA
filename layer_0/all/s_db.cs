using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0
{
    public interface s_db<T> where T : m_id
    {
        IMongoCollection<T> db { get; }
        Task upsert(T val);
        Task<T> get(string id);
    }
    public interface s_db
    {
        s_db<T> a_share<T>() where T : m_id;
        s_db<T> a_x<T>() where T : m_id;
        s_db<T> a_user<T>(string userid) where T : m_id;
    }
}