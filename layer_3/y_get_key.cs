﻿using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    public class y_get_key : y<y_get_key.output>
    {
        public override string z_xid => a.x_center;
        public override string z_yid => nameof(y_get_key);
        public override e_permission z_permission => e_permission.x;
        public string a_deviceid { get; set; }
        public class output : y_output
        {
            public m_key m_key { get; set; }
        }
    }
}
