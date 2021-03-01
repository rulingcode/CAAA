using layer_0.cell;
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

namespace layer_x
{
    /// <summary>
    /// Interaction logic for config.xaml
    /// </summary>
    public partial class config : UserControl
    {
        public config()
        {
            InitializeComponent();
            btn_stop.IsEnabled = false;
            a.api3.c_report = report;
            start();
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        async void start()
        {
            var dv = await x.db.a_x<m.data_item>().get("xip");
            if (dv == null)
                txt_endpoint.Text = p_res.get_endpoint(10000).ToString();
            else
                txt_endpoint.Text = p_crypto.convert<string>(dv.data);
        }
        void btn_start_Click(object sender, RoutedEventArgs e)
        {
           
        }
        private void add(string v, SolidColorBrush brush)
        {
            lbl_state.Inlines.Add(new Run()
            {
                Text = v,
                Foreground = brush
            });
        }
        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {

        }
        async void btn_login_Click(object sender, RoutedEventArgs e)
        {
            btn_start.IsEnabled = false;
            m_xip xip = new m_xip();
            try
            {
                xip.data = txt_endpoint.Text;
            }
            catch
            {
                lbl_state.Text = "invalid IP address";
                btn_start.IsEnabled = true;
                return;
            }
            if (txt_password.Password == null || txt_password.Password.Length < 5)
            {
                lbl_state.Text = "invalid password";
                btn_start.IsEnabled = true;
                return;
            }
            var dv = await a.api3.c_connect();
            if (dv != e_error.non)
            {
                dv = await a.api3.c_connect("wpf_x", txt_password.Password, a.xid);
                if (dv != e_error.non)
                {
                    lbl_state.Text = null;
                    add("connection faild : ", Brushes.Blue);
                    add(dv.ToString(), Brushes.Brown);
                    btn_start.IsEnabled = true;
                }
            }
        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}