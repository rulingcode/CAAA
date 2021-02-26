using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public class y_device_registration : y<y_device_registration.output>
    {
        public override string z_yid => nameof(y_device_registration);
        public override e_permission z_permission => e_permission.non;
        public byte[] a_key { get; set; }
        public byte[] a_login_skelet { get; set; }
        public class output : o
        {
            public string deviceid { get; set; }
        }
    }
}
