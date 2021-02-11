using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    public class y_set_x : y<y_set_x.output>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_set_x);
        public string a_xid { get; set; }
        public string a_endpoint { get; set; }
        public class output : y_output { }
    }
}
