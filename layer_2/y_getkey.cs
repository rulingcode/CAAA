using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    class y_getkey : y<y_getkey.o>
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_getkey);
        public override e_permission z_permission => e_permission.skelet;
        public string a_xid { get; set; }
        public class o : y_output
        {
            public m_key1 key { get; set; }
        }
    }
}
