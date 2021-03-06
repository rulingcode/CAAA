using layer_0.cell;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public abstract class s_lib
    {
        internal List<item> pages = new List<item>();
        internal class item
        {
            public string id { get; set; }
            public Type type { get; set; }
        }
        internal string name { get; set; }

        #region implement
        public abstract string id { get; }
        public void add_page<page>() where page : g_page, new()
        {
            page p = new page();
            if (pages.Any(i => i.id == p.page_name))
                throw new Exception("fkkvgjbjdhvhfjbjfnnvddf");
            pages.Add(new item()
            {
                id = p.page_name,
                type = typeof(page)
            });
        }
        public void add_y<T>() where T : y, new() => a.o3.s_add_y<T>();
        #endregion

        internal const string loading = nameof(loading);
        public static void start(Window window, s_lib lib) => a.start(window, lib);
    }
}
