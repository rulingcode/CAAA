﻿using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    class y_connect : y<y_connect.output>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_connect);
        public byte[] a_keys { get; set; }
        public byte[] a_login { get; set; }
        public override e_permission z_permission => e_permission.skelet;
        public class output : y_output
        {
            public string deviceid { get; set; }
        }
    }
}
