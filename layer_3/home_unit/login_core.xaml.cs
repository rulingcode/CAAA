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

namespace layer_3.home_unit
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    partial class login_core : Grid
    {
        public login_core()
        {
            InitializeComponent();
        }
        public TextBox txt_phone => (TextBox)pnl_phone.child;
        public PasswordBox txt_pass => (PasswordBox)pnl_pass.child;
    }
}
