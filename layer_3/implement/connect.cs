using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.implement
{
    class connect : y_connect
    {
        protected async override void implement(s_reply2<output> reply)
        {
            a_key = z_crypto.Decrypt(a_key, a.o3.private_key);
            m_key key = m_key.create(a_key);
            a_device = z_crypto.Decrypt(a_device, key);
            m_device device = z_crypto.convert<m_device>(a_device);
            var dv = await a.o3.create_device_s(device);
            output o = new output()
            {
                deviceid = dv,
                z_error = dv == null ? e_error.invalid_device_m : e_error.non
            };
        }
    }
}
