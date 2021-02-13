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

namespace z_message
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
            run();
        }

        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }

        private Task<m_key> get_key_c()
        {
            return Task.FromResult(z_dna.keys.message);
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            run();
        }

        private void run()
        {
            o2 = o2.create();
            o2.x_m = z_dna.keys.x_m;
            o2.add_y<message>();
            o2.c_get_key = get_key_c;
            o2.s_get_key = z_dna.keys.get_key_s;
            o2.check_userid_s = check_userid;
            o2.report = report;
            o2.add_x(new m_x() { id = "x_message", data = res.get_endpoint(10001).ToString() });
        }

        private Task<bool> check_userid(string deviceid, string userid) => z_dna.keys.check(deviceid, userid);
    }
}