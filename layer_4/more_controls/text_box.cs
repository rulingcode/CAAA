using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace layer_4.more_controls
{
    public class text_box : TextBox
    {
        private const string fa = "پچجحخهعغفقثصضگکمنتالبیسشوئدذرزطظژ";
        private const string free = "0123456789 .-_";

        public text_box()
        {
            TextChanged += Textbox_rtl_TextChanged;
        }
        private void Textbox_rtl_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.FlowDirection = get_direction(Text);
        }
        public static FlowDirection get_direction(string val)
        {
            foreach (var i in val)
            {
                if (free.Contains(i))
                    continue;
                if (fa.Contains(i))
                    return FlowDirection.RightToLeft;
                return FlowDirection.LeftToRight;
            }
            return FlowDirection.LeftToRight;
        }
    }
}
