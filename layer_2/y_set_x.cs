﻿using layer_1;
using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    public class y_set_x : y<y_set_x.output>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_set_x);
        public m_x a_x_m { get; set; }
        public class output : y_output { }
    }
}
