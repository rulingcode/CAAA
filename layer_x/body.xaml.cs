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
    /// Interaction logic for body.xaml
    /// </summary>
    public partial class body : UserControl
    {
        public body()
        {
            InitializeComponent();
            a.api3.c_report = report;
        }
        private Task report(m_report report)
        {
            return Task.CompletedTask;
        }
    }
}
