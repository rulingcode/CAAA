using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace skeleton.more_controls
{
    public class text_box : TextBox
    {
        public text_box()
        {
            TextChanged += Textbox_rtl_TextChanged;
        }
        private void Textbox_rtl_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.FlowDirection = text_direct.get_direction(Text);
        }
    }
}
