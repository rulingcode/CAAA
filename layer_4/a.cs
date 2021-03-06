using layer_0.cell;
using layer_3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace skeleton
{
    class a
    {
        static Window window;
        internal static o3 o3 = o3_factory.create();
        internal static c_lib lib_c;
        internal static c_app app_c;
        internal static g_panel panel;
        internal static s_lib develop_lib;
        internal static g_stage stage;
        internal static s_menu menu;
        private static void Window_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == Key.System)
            {
                e.Handled = true;
                menu.run(Key.System);
            }
            if (Keyboard.Modifiers.HasFlag(ModifierKeys.Control))
                menu.run(e.Key);
        }

        internal static void start(Window window, s_lib lib)
        {
            if (a.window != null)
                throw new Exception("ekvifbjjvhdhvjgjvjd");
            a.window = window;

            lib_c = new c_lib();
            app_c = new c_app();
            panel = new g_panel();
            window.PreviewKeyDown += Window_PreviewKeyDown;
            develop_lib = lib;
            if (lib != null && lib.id.Substring(0, 2) == "x_")
                window.WindowState = WindowState.Minimized;
            else
                window.WindowState = WindowState.Maximized;
            window.Content = panel.ui;
        }

        private static Task<byte[]> load(string key)
        {
            throw new NotImplementedException();
        }
    }
}