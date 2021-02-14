using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.implement
{
    class device_registration : y_device_registration
    {
        static long n = 0;
        protected async override void implement(s_reply2<output> reply)
        {
            a_key = z_crypto.Decrypt(a_key, a.o3.private_key);
            m_key key = m_key.create(a_key);
            a_device = z_crypto.Decrypt(a_device, key);
            m_login device_m = z_crypto.convert<m_login>(a_device);
            var deviceid = await a.o3.create_device_s(device_m);
            output o = new output()
            {
                deviceid = deviceid,
                z_error = deviceid == null ? e_error.invalid_device_login : e_error.non
            };
        }
    }
}
