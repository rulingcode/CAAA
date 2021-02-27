using layer_0.cell;
using layer_0.x_center;
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

namespace z_x_user
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        api3 o3;
        public MainWindow()
        {
            InitializeComponent();
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        async void Button_Click(object sender, RoutedEventArgs e)
        {
            o3 = api3_factory.create();
            o3.c_report = report;
            await o3.c_connect();
            //layer_0.x_center.y_xlogin login = new layer_0.x_center.y_xlogin()
            //{
            //    a_xid = "x_user",
            //    a_password = "1234"
            //};
            //var dv = await login.run(o3.c_run());
            y_set_x y = new y_set_x() { a_xip = new m_xip() { data = p_res.get_endpoint(10002).ToString() } };
            var dv = await y.run(o3.c_run("x_user"));
        }
    }
}