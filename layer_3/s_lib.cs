using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    public abstract class s_lib
    {
        internal List<item> pages = new List<item>();
        internal class item
        {
            public string id { get; set; }
            public Type type { get; set; }
        }
        public abstract string id { get; }
        internal string name { get; set; }
        public void add_c<page>() where page : g_page, new()
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
        public void add_s<y>() where y : layer_2.y => a.o2.add_y<y>();
    }
}
