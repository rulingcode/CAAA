using layer_0.cell;
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

namespace z_x_user
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        api3 o3;
        public MainWindow()
        {
            InitializeComponent();
            start();
        }
        async void start()
        {
            o3 = api3_factory.create();
            o3.c_report = report;
            await o3.c_connect();
        }

        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
    }
}