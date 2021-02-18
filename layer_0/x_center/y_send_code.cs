using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_center
{
    public class y_send_code : y<y_send_code.output>
    {
        public override string z_yid => nameof(y_send_code);
        public override e_permission z_permission => e_permission.k;
        public string a_phoneid { get; set; }
        public class output : y_output
        {
            
        }
    }
}
