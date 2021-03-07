using layer_0.cell;
using layer_0.x_center;
using layer_3;
using skeleton.more_controls;
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

namespace skeleton
{
    /// <summary>
    /// Interaction logic for connection.xaml
    /// </summary>
    public partial class connection : Border
    {
        public connection()
        {
            InitializeComponent();
        }
        public async void start()
        {
            a.api3 = api3_factory.create<m_sync>("db_skeleton");
            a.api3.c_report = report;
            a.run_null = a.api3.c_run();
            if (connect())
                go();
            else
            {
            retry:
                var e = await connect("1234");
                if (e == e_error.non)
                    go();
                else
                {
                    await Task.Delay(500);
                    goto retry;
                }
            }
        }
        int n = 0;
        private Task report(m_report report)
        {
            Dispatcher.InvokeAsync(met);
            void met()
            {
                switch (report.errorid)
                {
                    case "vkfbjhjbjfjbjf":
                        {
                            n++;
                            if (n < 2)
                                return;
                            var dv = "اتصال به سرویس پس از 0 مرتبه تلاش، شکست خورد. لطفا وضعیت شبکه یا اینترنت را بررسی کنید.";
                            dv = dv.Replace("0", n.ToString());
                            message.Content = dv;
                        }
                        break;
                    default:
                        {
                            message.Content = report.errorid + " : " + report.message;
                        }
                        break;
                }
            }
            return Task.CompletedTask;
        }
        private void go()
        {
            n = 0;
            a.main_panel = new main_panel();
            a.window.Content = null;
            a.window.Content = a.main_panel;
        }
        internal bool connect()
        {
            var db = a.api3.c_db;
            var dv = db.get(i => i.id == "key")?.data;
            if (dv == null)
                return false;
            else
            {
                a.api3.c_key = p_crypto.convert<m_key>(dv);
                return true;
            }
        }
        internal async Task<e_error> connect(string password)
        {
            y_register_c y = new();
            var dv_key = p_crypto.create_symmetrical_keys();
            y.a_key_data = m_key.create(dv_key);
            y.a_key_data = p_crypto.Encrypt(y.a_key_data, public_key.data);
            var login_m = new m_register_c()
            {
                a_device_name = Environment.MachineName,
                a_skeletid = "wpf_skeleton",
                a_password = password
            };
            y.a_register_data = p_crypto.convert(login_m);
            y.a_register_data = p_crypto.Encrypt(y.a_register_data, dv_key);
            var o = await y.run(a.run_null);
            if (o.z_error == e_error.non)
            {
                dv_key.id = o.deviceid;
                var db = a.api3.c_db;
                db.upsert(new m_data()
                {
                    id = "key",
                    data = p_crypto.convert(dv_key)
                });
                a.api3.c_key = dv_key;
            }
            return o.z_error;
        }
        internal void disconnect()
        {
            a.api3.c_db.coll.Delete("key");
            a.api3.c_key = null;
        }
        internal static void programing(Window window, z_app api)
        {
            if (a.window != null)
                return;
            a.window = window;
            window.Title = "skeleton";
            window.WindowState = WindowState.Maximized;
            connection connection = new connection();
            window.Content = connection;
            connection.start();
        }
    }
}
