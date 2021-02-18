using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    public class y_login : y<y_login.output>
    {
        public override string z_xid => a.x_center;
        public override string z_yid => nameof(y_login);
        public override e_permission z_permission => e_permission.k;
        public string a_userid { get; set; }
        public string a_password { get; set; }
        public class output : y_output { }
    }
}
