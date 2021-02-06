using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    class y_getid : y<y_getid.output>
    {
        public override e_permission z_permission => e_permission.skelet;
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_getid);
        public class output : y_output
        {
            public string newid { get; set; }
        }
    }
}
