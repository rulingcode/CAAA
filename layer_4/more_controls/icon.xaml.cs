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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace layer_4.more_controls
{
    /// <summary>
    /// Interaction logic for icon.xaml
    /// </summary>
    public partial class icon : Border
    {
        public icon()
        {
            InitializeComponent();
        }
        public string text
        {
            get => block.Text;
            set
            {
                block.Text = value;
                Visibility = value == null ? Visibility.Collapsed : Visibility.Visible;
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
                {
                    BorderBrush = Brushes.DarkBlue;
                }
                else
                {
                    BorderBrush = Brushes.LightBlue;
                }
            }
        }
        public Orientation orientation { get; set; }
    }
}
