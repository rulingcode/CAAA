using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace layer_3
{
    public abstract class g_ui : i_ui
    {
        public abstract UIElement ui { get; }
        public FrameworkElement z_frame => ui as FrameworkElement;
        public object DataContext { get => z_frame.DataContext; set => z_frame.DataContext = value; }
    }
}
