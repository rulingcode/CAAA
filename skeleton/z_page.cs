using layer_0.cell;
using layer_2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace skeleton
{
    public abstract class z_page
    {
        z_dialog dialog = default;
        internal c_run c_run = default;
        SemaphoreSlim g_locker = new SemaphoreSlim(1, 1);
        internal Grid body = new Grid();
        Border dialog_box = new Border() { Visibility = Visibility.Collapsed, Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0)) };
        public string appid { get; internal set; }
        public string a_userid { get; internal set; }
        public string z_name { get; internal set; }
        public abstract UIElement ui { get; }
        protected abstract void focus();
        internal void z_focus()
        {
            if (dialog == null)
                focus();
            else
                dialog.focus_();
        }
        public z_page()
        {
            body.Children.Add(ui);
            body.Children.Add(dialog_box);
        }
        public async Task<T> run<T>(z_dialog z)
        {
            await g_locker.WaitAsync();
            this.dialog = z;
            dialog_box.Child = z.ui;
            dialog_box.Visibility = Visibility.Visible;
            ui.IsEnabled = false;
            var dv = await z.get();
            this.dialog = null;
            ui.IsEnabled = true;
            focus();
            dialog_box.Visibility = Visibility.Collapsed;
            dialog_box.Child = default;
            g_locker.Release();
            return (T)dv;
        }
        public async Task<string> message(z_message.e_type e, string text, params string[] options)
        {
            z_message y = new z_message()
            {
                e = e,
                option = options,
                text = text,
            };
            var o = await y.run(this);
            return o.result;
        }
    }
}
