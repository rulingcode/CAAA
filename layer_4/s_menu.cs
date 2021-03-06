using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace skeleton
{
    class s_menu
    {
        public string userid { get; }
        public List<s_group> list = new List<s_group>();
        public s_menu(string userid)
        {
            this.userid = userid;
        }
        internal async Task load()
        {
            var dv = await a.app_c.get(userid);
            foreach (var i in dv)
            {
                list.Add(new s_group(i));
            }
            app_id = dv[0];
        }
        public string app_id { get; private set; }
        public string page_id => app.pageid;
        s_group app => list.First(i => i.id == app_id);
        int app_index => list.IndexOf(app);
        private void Right()
        {
            app.next();
            reset();
        }
        private void Left()
        {
            app.back();
            reset();
        }
        private void Down()
        {
            if (app_index == list.Count - 1)
                return;
            app_id = list[app_index + 1].id;
            reset();
        }
        private void up()
        {
            if (app_index == 0)
                return;
            app_id = list[app_index - 1].id;
            reset();
        }
        public void reset()
        {
            a.panel.set(app_index, list.Select(i => i.id).ToArray(), app.page_index, app.pages.ToArray());
            a.stage.reset();
        }
        internal void run(Key key)
        {
            switch (key)
            {
                case Key.Up: up(); break;
                case Key.Down: Down(); break;
                case Key.Right: Right(); break;
                case Key.Left: Left(); break;
            }
        }
    }
}
