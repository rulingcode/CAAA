using layer_0.cell;
using layer_0.x_center;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    class db_factory : c_db_factory
    {
        private const string file = "file";
        LiteDatabase lite;
        public db_factory(string cid)
        {
            //var folder = AppDomain.CurrentDomain.BaseDirectory;
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "caaa");
            Directory.CreateDirectory(folder);
            var file = Path.Combine(folder, cid + ".db");
            lite = new LiteDatabase(new ConnectionString() { Connection = ConnectionType.Shared, Filename = file });
            lite.Checkpoint();
        }
        public c_db<T> general<T>() where T : m_id => new db<T>(lite.GetCollection<T>("general_" + typeof(T).Name));
        public c_db<T> a_sync<T>(string xid, string userid) where T : m_sync => new db<T>(lite.GetCollection<T>("sync_" + xid + "_" + userid));
    }
}