using layer_0;
using layer_1;
using layer_3;
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
using layer_0.all;

namespace z_x_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        o3 o3 = o3.create();
        public MainWindow()
        {
            InitializeComponent();
            Height = 100; Width = 300; WindowState = WindowState.Minimized;
            a.o3.c_m_x = new m_xip() { data = p_res.get_endpoint(10000).ToString() };
            a.o3.c_report = c_report;
            a.o3.s_add_x(o3.c_m_x);

        }
        private Task c_report(m_report report)
        {
            throw new NotImplementedException();
        }
    }
}
