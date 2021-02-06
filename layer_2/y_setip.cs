using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    public class y_setip : y<y_setip.output>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_setip);
        public m_endpoint2 endpoint { get; set; }
        public class output : y_output { }
    }
}
