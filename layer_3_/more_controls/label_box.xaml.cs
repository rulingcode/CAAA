using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace layer_3.more_controls
{
    /// <summary>
    /// Interaction logic for label_box.xaml
    /// </summary>
    [ContentProperty("child")]
    public partial class label_box : Grid
    {
        public label_box()
        {
            InitializeComponent();
        }
        public string title { get => (string)lbl_title.Content; set => lbl_title.Content = value; }
        public FlowDirection title_direction { get => lbl_title.FlowDirection; set => lbl_title.FlowDirection = value; }
        public UIElement child { get => border.Child; set => border.Child = value; }
    }
}
