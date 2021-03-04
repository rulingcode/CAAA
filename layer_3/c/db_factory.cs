using layer_0.cell;
using LiteDB;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    class db_factory
    {
        private const string file = "file";
        LiteDatabase lite;
        public db_factory(string c_db_name)
        {
            //var folder = AppDomain.CurrentDomain.BaseDirectory;
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "caaa");
            Directory.CreateDirectory(folder);
            var file = Path.Combine(folder, c_db_name + ".db");
            lite = new LiteDatabase(new ConnectionString() { Connection = ConnectionType.Direct, Filename = file });
            lite.Checkpoint();
        }
        public c_db<T> api<T>() => new db<T>(lite.GetCollection<T>("free_" + typeof(T).Name));
        public c_db<T> sync<T>(string name) => new db<T>(lite.GetCollection<T>("sync_" + name));
        public ILiteCollection<BsonDocument> sync2(string name) => lite.GetCollection("sync_" + name);
    }
}