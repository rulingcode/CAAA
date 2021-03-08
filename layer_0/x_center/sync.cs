using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_center
{
    public class sync : m_sync
    {
        public string[] users { get; set; }
        public sealed override string z_xid => "x_center";
        public sealed override e_permission permission => e_permission.x;
    }
}
