﻿using System;
using System.Collections.Generic;
using System.Text;
using layer_0.all;

namespace layer_0.x_center
{
    public class y_get_x : y<y_get_x.output>
    {
        public override string z_yid => nameof(y_get_x);
        public override e_permission z_permission => e_permission.k;
        public class output : y_output
        {
            public m_xip[] list { get; set; }
        }
    }
}
