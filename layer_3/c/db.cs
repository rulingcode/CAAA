using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    class db
    {
        private const string file = "file";
        LiteDB.LiteDatabase lite;
        public db()
        {
            var folder = AppDomain.CurrentDomain.BaseDirectory;
            //var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "caaa");
            Directory.CreateDirectory(folder);
            var file = Path.Combine(folder, "api.db");
            lite = new LiteDatabase(new ConnectionString() { Connection = ConnectionType.Direct, Filename = file });
            lite.Checkpoint();
        }
        public ILiteCollection<T> api<T>(string name = null)
        {
            if (name == null)
                name = typeof(T).Name;
            return lite.GetCollection<T>(name);
        }
    }
}
