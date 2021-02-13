using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_dna
{
    public class y_message : y<y_message.output>
    {
        public override string z_xid => "x_message";
        public override string z_yid => nameof(y_message);
        public string a { get; set; }
        public string b { get; set; }
        public class output : y_output
        {
            public string c { get; set; }
        }
    }
}
