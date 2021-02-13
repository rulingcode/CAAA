using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_dna
{
    public class y_center : y<y_center.output>
    {
        public override string z_xid => "x_center";
        public override string z_yid => nameof(y_center);
        public int a { get; set; }
        public int b { get; set; }
        public class output : y_output
        {
            public int c { get; set; }
        }
    }
}
