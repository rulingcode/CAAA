using layer_2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace layer_3
{
    class a
    {
        static Window windowf;
        internal static o2 o2 = o2.create();
        internal static c_lib lib_c = new c_lib();
        internal static c_app app_c = new c_app();
        internal static g_panel panel = new g_panel();
        internal static s_lib develop_lib;

        internal static g_stage stage { get; set; }
        internal static Window window
        {
            get => windowf;
            set
            {
                windowf = value;
                windowf.PreviewKeyDown += Windowf_PreviewKeyDown;
            }
        }
        internal static s_menu menu { get; set; }
        private static void Windowf_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.System)
            {
                e.Handled = true;
                menu.run(Key.System);
            }
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                menu.run(e.Key);
        }

        internal static async void start(Window window, s_lib lib)
        {
            if (a.window != null)
                throw new Exception("ekvifbjjvhdhvjgjvjd");
            a.window = window;
            develop_lib = lib;
            if (lib != null && lib.id.Substring(0, 2) == "x_")
                window.WindowState = WindowState.Minimized;
            else
                window.WindowState = WindowState.Maximized;
            g_panel main_panel = panel;
            window.Content = main_panel.ui;
            m_connect dv = new m_connect()
            {
                skeletid = "skelet_windows_wpf",
                password = "free"
            };
            //await o2.connect_c(dv);
        }
    }
}