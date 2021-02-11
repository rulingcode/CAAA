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

namespace z_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        o2 o2 = o2.create();
        m_key key = z_crypto.create_symmetrical_keys();
        public MainWindow()
        {
            InitializeComponent();
            key.deviceid = "kfjbjfjvjf";
            o2.c_get_key = get_key_c;
            o2.report = report;
            o2.s_get_key = get_key_s;
            o2.x_m = new m_x() { data = res.get_endpoint(10000).ToString(), id = "x_center" };
            o2.add_y<test>();
            o2.add_x(o2.x_m);
            run();
        }
        async void run()
        {
            y_test y = new y_test() { a = 3, b = 4 };
            var dv = await y.run_c(o2.run("hasan"));
        }
        async Task<m_key> get_key_s(string deviceid)
        {
            await Task.CompletedTask;
            if (key.deviceid == deviceid) return key;
            return null;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        private Task<m_key> get_key_c()
        {
            return Task.FromResult(key);
        }
    }
}
