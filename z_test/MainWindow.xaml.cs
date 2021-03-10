﻿using layer_0.cell;
using layer_0.x_center;
using layer_0.x_user;
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

namespace z_test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        api3 api3 = api3_factory.create("db_test");
        c_run run_null;

        public MainWindow()
        {
            InitializeComponent();
            run_null = api3.c_run();
            api3.c_report = report;
        }
        internal bool connect()
        {
            var db = api3.c_db;
            var dv = db.api<m_data>().get(i => i.id == "key")?.data;
            if (dv == null)
                return false;
            else
            {
                api3.c_key = p_crypto.convert<m_key>(dv);
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
            var o = await y.run(api3.c_run());
            if (o.z_error == e_error.non)
            {
                dv_key.id = o.deviceid;
                var db = api3.c_db.api<m_data>();
                db.upsert(new m_data()
                {
                    id = "key",
                    data = p_crypto.convert(dv_key)
                });
                api3.c_key = dv_key;
            }
            return o.z_error;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        async void btn_upser_k(object sender, RoutedEventArgs e)
        {
            var userid = api3.c_db.api<m_string>().get("userid")?.data;
            if (userid == null)
            {
                Console.Beep();
                return;
            }
            y_upsert_info y = new() { a_name = "aaaa", a_userid = userid };
            c_run val = api3.c_run(userid);
            var dv = await y.run(val);

            Console.Beep();
        }
        async void btn_login_k(object sender, RoutedEventArgs e)
        {

            y_send_code y_send = new()
            {
                a_phoneid = "09123456789",
            };
            var o1 = await y_send.run(run_null);

            y_phone_login y_login = new()
            {
                a_phoneid = "09123456789",
                a_password = "12345"
            };
            var o2 = await y_login.run(run_null);
            if (o2.z_error == e_error.non)
            {
                api3.c_db.api<m_string>().upsert(new m_string() { id = "userid", data = o2.a_userid });
                Console.Beep();
            }
            else
            { }
        }
        async void btn_connect_k(object sender, RoutedEventArgs e)
        {

            if (connect())
                Console.Beep();
            else
            {
                var dv = await connect("1234");
                if (dv == e_error.non)
                    Console.Beep();
                else
                {

                }
            }
        }
    }
}
