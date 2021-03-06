using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace skeleton.more_controls
{
    public class text_block : TextBlock
    {
        public new string Text
        {
            get => base.Text;
            set
            {
                base.Text = value;
                FlowDirection = text_direct.get_direction(value);
            }
        }
    }
}
