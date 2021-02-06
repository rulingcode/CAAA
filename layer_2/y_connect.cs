using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    class y_connect : y<y_connect.output>
    {
        public byte[] keys { get; set; }
        public byte[] m_connect { get; set; }
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_connect);
        public override e_permission z_permission => e_permission.skelet;
        public class output : y_output { }
    }


}
