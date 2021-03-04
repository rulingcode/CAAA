using System;
using System.Collections.Generic;
using System.Text;
using layer_0.cell;

namespace layer_0.x_center
{
    public class y_get_x : z_y<y_get_x.output>
    {
        public override string z_yid => nameof(y_get_x);
        public override e_permission z_permission => e_permission.k;
        public class output : o_base
        {
            public item[] list { get; set; }
        }
        public class item
        {
            public string xid { get; set; }
            public m_xip xip { get; set; }
        }
    }
}
