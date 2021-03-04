using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.cell
{
    public class y_sync : y<y_sync.o>
    {
        public override string z_xid => a_xid;
        public override string z_yid => nameof(y_sync);
        public string a_xid { get; set; }
        public DateTime a_time { get; set; }
        public class o : o_base
        {
            public DateTime time { get; set; }
            public string[] deleted { get; set; }
            public string[] updated { get; set; }
        }
    }
}
