using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class c_key
    {
        private const string key_str = "key";
        m_key key = null;
        internal async Task<m_key> get()
        {
            if (key == null)
            {
                var dv = a.c_db.get(key_str);
                if (dv == null)
                {
                    y_device_registration y = new y_device_registration();
                    var dv_key = z_crypto.create_symmetrical_keys();
                    y.a_key = m_key.create(dv_key);
                    y.a_key = z_crypto.Encrypt(y.a_key, a.o3.public_key);
                    var device = await a.o3.create_device_c();
                    y.a_device = z_crypto.convert(device);
                    y.a_device = z_crypto.Encrypt(y.a_device, dv_key);
                    var o = await y.run_c(a.o3.run());
                    if (o.z_error == e_error.non)
                    {
                        dv_key.deviceid = o.deviceid;
                        a.c_db.set(key_str, z_crypto.convert(dv_key));
                        key = dv_key;
                        return key;
                    }
                    else
                        throw new Exception("gkfvjghvfchfbvhgndc");
                }
                else
                {
                    key = z_crypto.convert<m_key>(dv);
                    return key;
                }
            }
            else
                return key;
        }
    }
}
