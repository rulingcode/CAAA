using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class strart
    {
        internal async Task<e_error> run()
        {
            y_connect y = new y_connect();
            var key = z_crypto.create_symmetrical_keys();
            y.a_key = m_key.create(key);
            y.a_key = z_crypto.Encrypt(y.a_key, a.o3.public_key);
            var device = await a.o3.create_device_c();
            y.a_device = z_crypto.convert(device);
            y.a_device = z_crypto.Encrypt(y.a_device, key);
            var o = await y.run_c(a.o3.run());
            if (o.z_error == e_error.non)
            {
                key.deviceid = o.deviceid;
                a.key = key;
            }
            return o.z_error;
        }
    }
}
