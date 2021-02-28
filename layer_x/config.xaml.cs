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
            txt_endpoint.Text = p_res.get_endpoint(10000).ToString();
        }
        private void btn_start_Click(object sender, RoutedEventArgs e)
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
            }
        }
        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}