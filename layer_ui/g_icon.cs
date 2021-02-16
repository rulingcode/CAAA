using layer_3.more_controls;
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
        icon icon = new icon();
        public g_icon()
        {
            icon.DataContext = this;
        }
        public override UIElement ui => icon;
        public string text { get => icon.text; set => icon.text = value; }
        public bool is_select { get => icon.is_select; set => icon.is_select = value; }
        public Orientation orientation { get => icon.orientation; set => icon.orientation = value; }
    }
}
