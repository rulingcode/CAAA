using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    class y_getip : y<y_getip.output>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_getip);
        public override e_permission z_permission => e_permission.skelet;
        public class output : y_output
        {
            public m_endpoint2[] list { get; set; }
        }
    }
}
