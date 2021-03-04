using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_center
{
    public class m_device_users : m_sync
    {
        public string[] users { get; set; }
        public override string z_xid => "x_center";
        public override e_permission permission => e_permission.x;
    }
}
