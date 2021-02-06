using layer_2;
using System;
using System.Collections.Generic;
using System.Text;
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
        public static o3 o3 { get; set; }

    }
}