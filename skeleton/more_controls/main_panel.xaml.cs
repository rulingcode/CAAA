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

namespace skeleton.more_controls
{
    /// <summary>
    /// Interaction logic for main_panel.xaml
    /// </summary>
    public partial class main_panel : Grid
    {
        public main_panel()
        {
            InitializeComponent();
            h_stack.Children.Clear();
            v_stack.Children.Clear();
            for (int i = 0; i < 20; i++)
            {
                h_stack.Children.Add(new icon() { text = "صفحه" + i });
                v_stack.Children.Add(new icon() { text = "نرم افزار" + i });
            }
        }
        public void set(string[] apps, int app, string pages, int page)
        {

        }
        internal void show(z_page page)
        {
            a.page = page;
            stage.Child = page.ui;
        }
    }
}
