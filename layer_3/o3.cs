using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace layer_3
{
    public class o3
    {
        internal const string x_app = nameof(x_app);
        internal const string loading = nameof(loading);
        o3()
        {
            a.o3 = this;
           
        }
        public static o3 create() => a.o3 == null ? new o3() : null;
        public static void start(Window window, s_lib lib)
        {
            a.window = window;
            a.develop_lib = lib;
            window.WindowState = WindowState.Maximized;
            g_panel main_panel = a.panel;
            window.Content = main_panel.ui;
            a.stage.set("ali");
        }
    }
}
