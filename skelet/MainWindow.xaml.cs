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

namespace skelet
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        api3 api3 = api3_factory.create("db_skelet");
        public MainWindow()
        {
            InitializeComponent();
            api3.c_report = report;
            start();
        }
        async void start()
        {
            txt_phone.IsEnabled = txt_pass.IsEnabled = false;
            //await api3.c_connect("wpf_client", "wpf_client_password", null);
            txt_phone.IsEnabled = txt_pass.IsEnabled = true;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        private void txt_phone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                txt_pass.Focus();
        }

        async void txt_pass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                y_phone_login y = new()
                {
                    a_phoneid = txt_phone.Text,
                    a_password = txt_pass.Text
                };
                var dv = await y.run(api3.c_run());

            }
        }
    }
}