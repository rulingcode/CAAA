using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_center
{
    public class sync_center : m_sync
    {
        public sealed override string z_xid => "x_center";
        public sealed override e_permission z_permission => e_permission.x;
        public m_key key { get; set; }
        public string[] users { get; set; }
    }
}
