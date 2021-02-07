using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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

        public void add_y<y>() where y : layer_2.y => a.o2.add_y<y>();
        #endregion

        #region static
        internal const string x_app = nameof(x_app);
        internal const string loading = nameof(loading);
        public static void start(Window window, s_lib lib)
        {
            a.window = window;
            a.develop_lib = lib;
            window.WindowState = WindowState.Maximized;
            g_panel main_panel = a.panel;
            window.Content = main_panel.ui;
            a.stage.set("ali");
        }
        #endregion
    }
}
