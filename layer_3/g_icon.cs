using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace layer_3
{
    class g_icon : g_ui
    {
        public override UIElement ui => border;

        Border border = new Border() { Margin = new Thickness(1) };
        TextBlock block = new TextBlock()
        {
            MinWidth = 120,
            Padding = new Thickness(10),
            TextAlignment = TextAlignment.Center
        };
        public g_icon()
        {
            border.BorderThickness = new Thickness(2);
            border.BorderBrush = Brushes.LightBlue;
            border.Child = block;
            DataContext = this;
            text = "icon";
        }
        public string text
        {
            get => block.Text;
            set
            {
                block.Text = value;
                border.Visibility = value == null ? Visibility.Collapsed : Visibility.Visible;
            }
        }
        bool is_selectf = false;
        public bool is_select
        {
            get => is_selectf;
            set
            {
                is_selectf = value;
                if (is_selectf)
                    border.BorderBrush = Brushes.DarkBlue;
                else
                    border.BorderBrush = Brushes.LightBlue;
            }
        }
        public Orientation orientation { get; set; }
    }
}
