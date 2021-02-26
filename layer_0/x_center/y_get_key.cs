using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public class y_get_key : y<y_get_key.output>
    {
        public override string z_yid => nameof(y_get_key);
        public override e_permission z_permission => e_permission.x;
        public string a_deviceid { get; set; }
        public class output : o_base
        {
            public m_key m_key { get; set; }
        }
    }
}
