﻿using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public class y_register_c : z_y<y_register_c.o>
    {
        public override string z_yid => nameof(y_register_c);
        public override e_permission z_permission => e_permission.non;
        public byte[] a_key_data { get; set; }
        public byte[] a_register_data { get; set; }
        public class o : o_base
        {
            public string deviceid { get; set; }
        }
    }
}
