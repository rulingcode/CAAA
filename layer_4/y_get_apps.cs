using layer_0.all;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_4
{
    class y_get_apps : y<y_get_apps.o>
    {
        public override e_permission z_permission => e_permission.k;
        public override string z_xid => s_lib.x_app;
        public override string z_yid => nameof(y_get_apps);
        public string userid { get; set; }
        public class o : y_output
        {
            public string[] apps { get; set; }
        }
    }
}
