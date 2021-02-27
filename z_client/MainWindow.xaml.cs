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

        private const string u1 = "u_60392e5baa60c82edbb21fb3";
        api3 o3;
        async void Button_Click(object sender, RoutedEventArgs e)
        {
            o3 = api3_factory.create();
            await o3.c_connect("d_client");
            layer_0.x_user.y_upsert_name y = new()
            {
                a_fullname = "ali",
                a_userid = u1
            };
            var dv = await y.run(o3.c_run(u1));
        }

        private async Task login()
        {
            {
                y_send_code y = new y_send_code();
                y.a_phoneid = "09123456789";
                var dv = await y.run(o3.c_run());
            }
            {
                y_phone_login y = new y_phone_login();
                y.a_phoneid = "09123456789";
                y.a_password = "26520";
                var dv = await y.run(o3.c_run());
            }
        }
    }
}
