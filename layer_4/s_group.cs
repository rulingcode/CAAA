using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_4
{
    class s_group
    {
        public List<string> pages = new List<string>() { s_lib.loading };
        public string id { get; set; }
        public s_group(string appid)
        {
            id = appid;
            load();
        }
        async void load()
        {
            pages = new List<string>(await a.lib_c.get_pages(id));
            pageid = pages[0];
            if (a.menu != null)
                a.stage.set(a.menu.userid);
        }
        public string pageid { get; private set; } = s_lib.loading;
        public int page_index => pages.IndexOf(pageid);
        public void next()
        {
            if (page_index == pages.Count - 1)
                return;
            pageid = pages[page_index + 1];
        }
        public void back()
        {
            if (page_index <= 0)
                return;
            pageid = pages[page_index - 1];
        }
    }
}
