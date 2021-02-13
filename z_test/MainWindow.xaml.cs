﻿using layer_1;
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
        public MainWindow()
        {
            InitializeComponent();
            o2.c_get_key = get_key_c;
            o2.report = report;
            o2.s_get_key = get_key_s;
            o2.x_m = z_dna.keys.x_m;
            o2.add_y<center>();
            o2.add_x(o2.x_m);
            o2.check_userid_s = chack_userid_s;
            WindowState = WindowState.Minimized;
        }
        private Task<bool> chack_userid_s(string deviceid, string userid) => z_dna.keys.check(deviceid, userid);
        async Task<m_key> get_key_s(string id)
        {
            await Task.CompletedTask;
            if (z_dna.keys.client.deviceid == id) return z_dna.keys.client;
            if (z_dna.keys.message.deviceid == id) return z_dna.keys.message;
            return null;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
        private Task<m_key> get_key_c()
        {
            throw new Exception("kjvjfhjbhfjhjf");
        }
    }
}