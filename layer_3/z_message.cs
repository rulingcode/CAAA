using System;
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
        internal override UIElement ui => border;
        public e_type e { get; set; }
        public string title { get; set; }
        public string text { get; set; }
        public string[] option { get; set; }
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

        Border border = new Border() { Margin = new Thickness(10) };
        StackPanel panel = new StackPanel();
        ListBox lb = new ListBox()
        {
            MinWidth = 80,
            BorderThickness = new Thickness(2),
            BorderBrush = Brushes.LightBlue,
            HorizontalAlignment = HorizontalAlignment.Left,
            Margin = new Thickness(5)
        };
        Border block_border = new Border()
        {
            MinWidth = 200,
            BorderThickness = new Thickness(2),
            BorderBrush = Brushes.LightBlue,
            CornerRadius = new CornerRadius(0, 10, 0, 0),
            Padding = new Thickness(5),
            Background = Brushes.White
        };
        TextBlock text_block = new TextBlock()
        {
            Padding = new Thickness(5)
        };
        public z_message()
        {
            border.Child = panel;
            panel.Children.Add(lb);
            block_border.Child = text_block;
            panel.Children.Add(block_border);
            border.HorizontalAlignment = HorizontalAlignment.Left;
            border.VerticalAlignment = VerticalAlignment.Bottom;
            lb.PreviewKeyDown += Lb_PreviewKeyDown;
        }
        private void Lb_PreviewKeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (e.Key == System.Windows.Input.Key.Enter)
                reply(new o() { result = lb.SelectedValue as string });
        }
        protected override void implement()
        {

            text_block.Text = text;
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