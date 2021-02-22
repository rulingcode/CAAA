using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Text;
using layer_0.all;

namespace layer_2
{
    class y_get_x : y<y_get_x.output>
    {
        public override string z_xid => a.x_center;
        public override string z_yid => nameof(y_get_x);
        public override e_permission z_permission => e_permission.k;
        public class output : y_output
        {
            public m_xip[] list { get; set; }
        }
    }
}
