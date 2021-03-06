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
    public abstract class g_page
    {
        z z = default;
        internal c_run run_c = default;
       
        SemaphoreSlim g_locker = new SemaphoreSlim(1, 1);
        internal Grid body = new Grid();
        Border dialog = new Border()
        {
            Visibility = Visibility.Collapsed,
            Background = new SolidColorBrush(Color.FromArgb(70, 0, 0, 0))
        };
        internal string appid { get; set; }
        public string userid { get; internal set; }
        public abstract string page_name { get; }
        protected abstract void focus();
        internal void z_focus()
        {
            if (z == null)
                focus();
            else
                z.focus_();
        }
        public abstract UIElement ui { get; }
        public g_page()
        {
            body.Children.Add(ui);
            body.Children.Add(dialog);
        }
        public async Task<T> run<T>(y y) where T : y_output => await run_c.get<T>(y);
        public async Task<T> run<T>(z z)
        {
            await g_locker.WaitAsync();
            this.z = z;
            dialog.Child = z.ui;
            dialog.Visibility = Visibility.Visible;
            ui.IsEnabled = false;
            var dv = await z.get();
            this.z = null;
            ui.IsEnabled = true;
            focus();
            dialog.Visibility = Visibility.Collapsed;
            dialog.Child = default;
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
