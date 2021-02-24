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
            var folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "caaa");
            Directory.CreateDirectory(folder);
            var file = Path.Combine(folder, "local.db");
            lite = new LiteDB.LiteDatabase(file);
        }
        public ILiteCollection<T> get<T>(string name = null) => lite.GetCollection<T>(name);
        public byte[] get(string name)
        {
            return get<item>(file).FindOne(i => i.id == name)?.data;
        }
        public void set(string name, byte[] data)
        {
            get<item>(file).Upsert(new item() { id = name, data = data });
        }
        class item
        {
            public string id { get; set; }
            public byte[] data { get; set; }
        }
    }
}
