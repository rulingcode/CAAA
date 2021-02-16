using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class y_device_registration : y<y_device_registration.output>
    {
        public override string z_xid => a.x_center;
        public override string z_yid => nameof(y_login);
        public byte[] a_key { get; set; }
        public byte[] a_device { get; set; }
        public class output : y_output
        {
            public string deviceid { get; set; }
        }
    }
}
