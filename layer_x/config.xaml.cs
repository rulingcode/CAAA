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
        private e_state state1 = e_state.login_requiered;
        e_state state
        {
            get => state1; set
            {
                state1 = value;
                reset();
            }
        }
        public config()
        {
            InitializeComponent();
            a.api3.c_report = report;
            start();
        }
        enum e_state
        {
            inp,
            login_requiered,
            host_stop,
            host_runing
        }
        void reset()
        {
            switch (state)
            {
                case e_state.inp:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled =
                        btn_logout.IsEnabled =

                        txt_myhost.IsEnabled =
                        btn_start.IsEnabled =
                        btn_stop.IsEnabled = false;
                    }
                    break;
                case e_state.login_requiered:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled = true;
                        btn_logout.IsEnabled =

                        txt_myhost.IsEnabled =
                        btn_start.IsEnabled =
                        btn_stop.IsEnabled = false;
                    }
                    break;
                case e_state.host_stop:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled = false;
                        btn_logout.IsEnabled = true;

                        txt_myhost.IsEnabled =
                        btn_start.IsEnabled = true;
                        btn_stop.IsEnabled = false;
                    }
                    break;
                case e_state.host_runing:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled =
                        btn_logout.IsEnabled = false;

                        txt_myhost.IsEnabled = false;
                        btn_start.IsEnabled = false;
                        btn_stop.IsEnabled = true;
                        add("Host Runing", Brushes.Green, true);
                    }
                    break;
            }
        }
        void start()
        {
            reset();
            var dv = a.key.connect();
            if (dv == e_error.non)
            {
                host_runing();
            }
            else
            {
                btn_login.IsEnabled = true;
                add("login required", Brushes.Blue, true);
            }
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        void btn_start_Click(object sender, RoutedEventArgs e)
        {
            state = e_state.inp;
            m_xip xip = new m_xip();
            try
            {
                xip.data = txt_myhost.Text;
            }
            catch
            {
                add("invalid IP address", Brushes.Brown, true);
                return;
            }
            a.api3.c_db.upsert(new m_data()
            {
                data = p_crypto.convert(xip.data),
                id = "xip"
            });
            host_runing();
        }
        private void host_runing()
        {
            byte[] data = a.api3.c_db.get("xip")?.data;
            if (data == null)
            {
                state = e_state.host_stop;
                return;
            }
            try
            {
                txt_myhost.Text = p_crypto.convert<string>(data);
                a.api3.s_xip = new m_xip() { data = txt_myhost.Text };
                state = e_state.host_runing;
            }
            catch (Exception ex)
            {
                state = e_state.host_stop;
                add(ex.Message, Brushes.Brown, true);
                return;
            }
        }
        private void add(string v, SolidColorBrush brush, bool clear = false)
        {
            if (clear)
                lbl_state.Text = null;
            lbl_state.Inlines.Add(new Run()
            {
                Text = v,
                Foreground = brush
            });
        }
        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            a.api3.s_xip = null;
            state = e_state.host_stop;
        }
        async void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (txt_password.Password == null || txt_password.Password.Length < 5)
            {
                add("invalid password", Brushes.Brown, true);
                btn_login.IsEnabled = txt_password.IsEnabled = true;
                return;
            }

            var dv = await a.key.connect(txt_password.Password);
            if (dv == e_error.non)
                host_runing();
            else
            {
                btn_login.IsEnabled = txt_password.IsEnabled = true;
                add("Error : ", Brushes.Brown, true);
                add(dv.ToString(), Brushes.Brown);
            }
        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            a.key.disconnect();
            state = e_state.login_requiered;
        }
    }
}