using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace layer_4
{
    class g_panel : g_ui
    {
        public override UIElement ui => body;

        private const int max = 10;
        Grid body = new Grid();
        StackPanel g_pages = new StackPanel() { Orientation = Orientation.Horizontal, Margin = new Thickness(2) };
        StackPanel g_apps = new StackPanel() { Orientation = Orientation.Vertical, Margin = new Thickness(2) };
        public g_panel()
        {
            body.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(0, GridUnitType.Auto) });
            body.ColumnDefinitions.Add(new ColumnDefinition());
            body.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(0, GridUnitType.Auto) });
            body.RowDefinitions.Add(new RowDefinition());
            body.Children.Add(g_apps);
            body.Children.Add(g_pages);
            a.stage = new g_stage();
            body.Children.Add(a.stage.ui);
            Grid.SetRow(a.stage.ui, 1);
            Grid.SetColumn(a.stage.ui, 1);
            Grid.SetColumn(g_pages, 1);
            Grid.SetRow(g_apps, 1);
            for (int i = 0; i < max; i++)
            {
                g_apps.Children.Add(new g_icon() { orientation = Orientation.Horizontal }.ui);
                g_pages.Children.Add(new g_icon() { orientation = Orientation.Vertical }.ui);
            }
        }
        g_icon app;
        g_icon page;
        public void set(int app_index, string[] apps, int page_index, string[] pages)
        {
            if (app != null)
            {
                app.is_select = false;
                page.is_select = false;
            }

            for (int i = 0; i < max; i++)
            {
                g_app(i).text = i < apps.Length ? apps[i] : null;
                g_page(i).text = i < pages.Length ? pages[i] : null;
            }

            app = g_app(app_index);
            app.is_select = true;

            page = g_page(page_index);
            page.is_select = true;
        }
        g_icon g_app(int app_index) => (g_icon)(g_apps.Children[app_index] as FrameworkElement).DataContext;
        g_icon g_page(int page_index) => (g_icon)(g_pages.Children[page_index] as FrameworkElement).DataContext;
    }
}
