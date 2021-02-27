using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public class y_phone_login : z_y<y_phone_login.output>
    {
        public override string z_yid => nameof(y_phone_login);
        public override e_permission z_permission => e_permission.k;
        public string a_phoneid { get; set; }
        public string a_password { get; set; }
        public class output : o_base<error>
        {
            public string userid { get; set; }
        }
        public enum error
        {
            non,
            invalid_params
        }
    }
}
