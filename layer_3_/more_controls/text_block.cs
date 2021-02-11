using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace layer_3.more_controls
{
    public class text_block : TextBlock
    {
        public new string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                FlowDirection = text_box.get_direction(value);
            }
        }
    }
}
