using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_center;

namespace z_x_center.z
{
    class get_x : y_get_x
    {
        internal static output o = new output() { list = new item[0] };
        protected override void implement()
        {
            _ = this;
            reply(o);
        }
    }
}
