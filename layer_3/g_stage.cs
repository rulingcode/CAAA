using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace layer_3
{
    class g_stage : g_ui
    {
        Border border = new Border();
        Grid grid = new Grid();
        List<s_menu> users = new List<s_menu>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        List<g_page> pages = new List<g_page>();
        public g_stage()
        {
            border.Padding = new Thickness(2);
            border.Margin = new Thickness(1);
            border.BorderThickness = new Thickness(2);
            border.BorderBrush = Brushes.Silver;
            border.Child = grid;
        }
        public override UIElement ui => border;
        public async void reset()
        {
            await locker.WaitAsync();
            grid.Children.Clear();
            var page = pages.FirstOrDefault(i => i.userid == a.menu.userid && i.appid == a.menu.app_id && i.page_name == a.menu.page_id);
            if (page == null)
            {
                page = await a.lib_c.get(a.menu.app_id, a.menu.page_id, a.menu.userid);
                pages.Add(page);
            }
            grid.Children.Add(page.body);
            page.z_focus();
            locker.Release();
        }
        public async void set(string userid)
        {
            await locker.WaitAsync();
            s_menu menu = users.FirstOrDefault(i => i.userid == userid);
            if (menu == null)
            {
                menu = new s_menu(userid);
                await menu.load();
                users.Add(menu);
            }
            a.menu = menu;
            menu.reset();
            locker.Release();
        }
    }
}