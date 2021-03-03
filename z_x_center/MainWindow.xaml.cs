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
using layer_0.cell;
using z_x_center.z;

namespace z_x_center
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Height = 100; Width = 300; WindowState = WindowState.Minimized;
            start();
        }
        async void start()
        {
            a.api3 = api3_factory.create("db_x_center");
            a.api3.c_report = c_report;
            a.api3.z_get_key = get_key.get;
            a.key = new key();

            a.api3.s_add_y<register_x>();
            a.api3.s_add_y<register_c>();
            a.api3.s_add_y<get_key>();
            a.api3.s_add_y<get_x>();
            a.api3.s_add_y<phone_login>();
            a.api3.s_add_y<send_code>();
            a.api3.s_add_y<set_x>();
            a.api3.s_xip = new m_xip() { id = "x_center", data = p_res.get_endpoint(10000).ToString() };
            a.set_password("x_user");
        }
        private Task c_report(m_report report)
        {
            return Task.CompletedTask;
        }
    }
}
