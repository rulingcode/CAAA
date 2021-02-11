using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_test
{
    class y_test : y<y_test.output>
    {
        public override string z_xid => "x_center";
        public override string z_yid => nameof(y_test);
        public int a { get; set; }
        public int b { get; set; }
        public class output : y_output
        {
            public int c { get; set; }
        }
    }
}
