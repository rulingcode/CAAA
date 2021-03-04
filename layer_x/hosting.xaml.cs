using layer_0.cell;
using layer_0.x_center;
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
    /// Interaction logic for hosting.xaml
    /// </summary>
    partial class hosting : UserControl
    {
        e_state statef;
        enum e_state
        {
            stop,
            inp,
            runing
        }
        e_state state
        {
            get => statef;
            set
            {
                statef = value;
                switch (statef)
                {
                    case e_state.inp:
                        {
                            btn_start.IsEnabled = false;
                            btn_stop.IsEnabled = false;
                            txt_myhost.IsEnabled = false;
                        }
                        break;
                    case e_state.stop:
                        {
                            btn_start.IsEnabled = true;
                            btn_stop.IsEnabled = false;
                            txt_myhost.IsEnabled = true;
                            message("service is stop.", Brushes.Blue);
                        }
                        break;
                    case e_state.runing:
                        {
                            btn_start.IsEnabled = false;
                            btn_stop.IsEnabled = true;
                            txt_myhost.IsEnabled = false;
                            message("service is runing.", Brushes.Blue);
                        }
                        break;
                }
            }
        }
        public hosting()
        {
            InitializeComponent();
            state = e_state.stop;
        }
        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                m_xip xip = new() { data = txt_myhost.Text };
            }
            catch
            {
                message("error : invalid address.", Brushes.Brown);
            }
            start();
        }
        async void start()
        {
            try
            {
                a.api3.s_xip = new m_xip() { data = txt_myhost.Text };
                a.api3.c_db.upsert(new m_data() { id = "xip", data = p_crypto.convert(txt_myhost.Text) });
                y_set_x y = new y_set_x()
                {
                    a_xip = a.api3.s_xip
                };
                c_run run = a.api3.c_run(a.xid);
                var dv = await y.run(run);
                if (dv.z_error != e_error.non)
                    throw new Exception(dv.z_error.ToString());
                state = e_state.runing;
            }
            catch (Exception e)
            {
                message("error : " + e.Message, Brushes.Brown);
            }
        }
        private void message(string v, SolidColorBrush brush)
        {
            lbl_state.Text = null;
            lbl_state.Inlines.Add(new Run()
            {
                Text = v,
                Foreground = brush
            });
        }
        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {

        }
        internal void login(bool v)
        {
            if (v)
            {
                var dv = a.api3.c_db.get("xip");
                if (dv == null)
                    txt_myhost.Text = p_res.get_endpoint(0).ToString();
                else
                    txt_myhost.Text = p_crypto.convert<string>(dv.data);
                state = e_state.stop;
            }
            else
            {
                a.api3.s_xip = null;
                state = e_state.inp;
            }
        }

    }
}