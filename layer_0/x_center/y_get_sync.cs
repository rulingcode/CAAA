using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_center
{
    public class y_get_sync : z_y<y_get_sync.o>
    {
        public sealed override string z_yid => nameof(y_get_sync);
        public sealed override e_permission z_permission => e_permission.x;
        public DateTime time { get; set; }
        public class o : o_base
        {
            public DateTime time { get; set; }
            public string[] deleted { get; set; }
            public m_device_users[] items { get; set; }
        }
    }
}