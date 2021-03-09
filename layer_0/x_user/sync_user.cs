using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_user
{
    public class sync_user : m_sync
    {
        public sealed override string z_xid => "x_user";
        public string name { get; set; }
        public string national_id { get; set; }
        public e_status status { get; set; }
        public string phoneid { get; set; }
        public bool is_contact { get; set; }
        public e_gender gender { get; set; }
    }
}
