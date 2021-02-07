using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace layer_3
{
    class page_loading : g_page
    {
        Border border = new Border() { Background = Brushes.Pink };
        public override string page_name => s_lib.loading;
        public override UIElement ui => border;
        protected override void focus()
        {

        }
    }
}
