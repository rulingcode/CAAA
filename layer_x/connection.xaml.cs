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
    public partial class connection : UserControl
    {
        private e_state state1 = e_state.logout;
        e_state state
        {
            get => state1; set
            {
                state1 = value;
                reset();
            }
        }
        public connection()
        {
            InitializeComponent();
            txt_password.Password = "qweasdzxc";
        }
        public async void start()
        {
            if (await a.key.connect() == e_error.non)
                state = e_state.login;
            else
                state = e_state.logout;
        }
        enum e_state
        {
            inp,
            logout,
            login
        }
        void reset()
        {
            switch (state)
            {
                case e_state.inp:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled =
                        btn_logout.IsEnabled = false;
                        add("service in process.", Brushes.Brown, true);
                    }
                    break;
                case e_state.logout:
                    {
                        txt_password.IsEnabled =
                        btn_login.IsEnabled = true;
                        btn_logout.IsEnabled = false;
                        add("service is logout.", Brushes.Black, true);
                        a.body.hosting.login(false);
                    }
                    break;
                case e_state.login:
                    {
                        txt_password.IsEnabled = false;
                        btn_login.IsEnabled = false;
                        btn_logout.IsEnabled = true;
                        add("service is login.", Brushes.Blue, true);
                        a.body.hosting.login(true);
                    }
                    break;
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
        async void btn_login_Click(object sender, RoutedEventArgs e)
        {
            if (txt_password.Password == null || txt_password.Password.Length < 5)
            {
                add("error : invalid password", Brushes.Brown, true);
                return;
            }
            state = e_state.inp;
            var dv = await a.key.connect(txt_password.Password);

            if (dv == e_error.non)
                state = e_state.login;
            else
            {
                state = e_state.logout;
                add("error : " + dv, Brushes.Brown, true);
            }
        }
        private void btn_logout_Click(object sender, RoutedEventArgs e)
        {
            a.key.disconnect();
            state = e_state.logout;
        }
    }
}