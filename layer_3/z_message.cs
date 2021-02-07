﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace layer_3
{
    public class z_message : z<z_message.o>
    {
        internal override UIElement ui => mb;
        public e_type e { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string[] option { get; set; }
        ListBox lb => mb.lb;

        public class o
        {
            public string result { get; set; }
        }
        public enum e_type
        {
            info,
            warning,
            error
        }
        more_controls.message_box mb = new more_controls.message_box() { Margin = new Thickness(20) };

        public z_message()
        {
            lb.PreviewKeyDown += Lb_PreviewKeyDown;
        }
        private void Lb_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                reply(new o() { result = lb.SelectedValue as string });
        }
        protected override void implement()
        {

            mb.txt_message.Text = text;
            if (option == null)
                option = new string[] { "Ok" };
            ObservableCollection<string> l = new ObservableCollection<string>(option);
            lb.ItemsSource = l;
            lb.SelectedIndex = 0;
        }
        protected override void focus()
        {
            lb.UpdateLayout();
            lb.SelectedIndex = 0;
            DependencyObject dependencyObject = lb.ItemContainerGenerator.ContainerFromIndex(lb.SelectedIndex);
            var lbi = dependencyObject as ListBoxItem;
            if (lbi == null)
                lb.Focus();
            else
                lbi.Focus();
        }
    }
}