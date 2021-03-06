using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public abstract class app_base
    {
        List<item> list = new List<item>();
        class item
        {
            public string name;
            public Type type;
        }
        public static void programing(Window window, app_base app) => connection.programing(window, app);
        public abstract string app_name { get; }
        public void add<T>(string name) where T : page
        {
            if (list.Any(i => i.name == name))
                throw new Exception("kkjbjgjbjfjvhdhchd");
            list.Add(new item() { name = name, type = typeof(T) });
        }
    }
}
