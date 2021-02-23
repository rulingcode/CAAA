using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public class x_sync : m_sync
    {
        public override string z_xid => "x_center";
        public string phoneid { get; set; }
        public string deviceid { get; set; }
    }
}
