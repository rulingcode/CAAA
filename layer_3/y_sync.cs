﻿using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class y_sync : y<y_sync.output>
    {
        public override string z_xid => a_xid;
        public override string z_yid => nameof(y_sync);
        public string a_xid { get; set; }
        public long index { get; set; }
        public class output : y_output
        {
            public long index { get; set; }
            public string[] deleted { get; set; }
            public string updated { get; set; }
        }
    }
}