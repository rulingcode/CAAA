using layer_0.cell;
using layer_x;
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
        public MainWindow()
        {
            InitializeComponent();
            x.z_create("x_user", this);
            x.add_y<z.upsert_name>();
            // x.start += X_start;
        }
        async void X_start()
        {
        retry:
            layer_0.x_user.y_upsert_name y = new() { a_fullname = "aaa", a_userid = "bbb" };
            var dv = await y.run(x.run_x);
            if (dv.z_error != e_error.non)
                goto retry;
        }
    }
}
