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

namespace z_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        api3 o3;
        async void Button_Click(object sender, RoutedEventArgs e)
        {
            o3 = api3_factory.create();
            await o3.c_connect();
            {
                y_send_code y = new y_send_code();
                y.a_phoneid = "09123456789";
                var dv = await y.run(o3.c_run());
            }
            {
                y_login y = new y_login();
                y.a_phoneid = "09123456789";
                y.a_password = "38615";
                var dv = await y.run(o3.c_run());
            }
        }
    }
}
