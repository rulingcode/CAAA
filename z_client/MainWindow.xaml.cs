using layer_1;
using layer_2;
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
using z_dna;

namespace z_client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        o2 o2;
        public MainWindow()
        {
            InitializeComponent();
            WindowState = WindowState.Minimized;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        private Task<m_key> get_key_c()
        {
            return Task.FromResult(z_dna.keys.client);
        }
        async void btn_Click(object sender, RoutedEventArgs e)
        {
            o2 = o2.create();
            o2.c_get_key = get_key_c;
            o2.report = report;
            o2.x_m = new m_x() { id = "x_center", data = res.get_endpoint(10000).ToString() };

            y_message ym = new y_message()
            {
                a = "aaa",
                b = "bbb"
            };
            c_run run = o2.run("u_ali");
            var o = await ym.run_c(run);
        }
    }
}
