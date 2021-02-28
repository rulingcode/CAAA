using layer_0.cell;
using layer_0.x_center;
using layer_3;
using layer_x;
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

namespace z_x_user
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        x_core core;
        public MainWindow()
        {
            InitializeComponent();
            core = layer_x.apix_factory.create("x_user", this);
        }
    }
}