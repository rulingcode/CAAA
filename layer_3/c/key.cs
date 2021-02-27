using layer_0;
using layer_1;
using layer_2;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_3.c
{
    class key
    {
        private const string key_str = "key";
        internal async Task connect(string device_name)
        {
            var db = a.c_db.api<m.data_item>();
            var dv = db.FindOne(i => i.id == key_str)?.data;
            if (dv == null)
            {
                y_device_registration y = new y_device_registration();
                var dv_key = p_crypto.create_symmetrical_keys();
                y.a_key = m_key.create(dv_key);
                y.a_key = p_crypto.Encrypt(y.a_key, public_key.data);
                m_login_skelet login_m = new m_login_skelet()
                {
                    skelet_id = "k_windows",
                    password = "kfkbjgjbhdjfjbjgjnjfjbg",
                    device_name = device_name
                };
                y.a_login_skelet = p_crypto.convert(login_m);
                y.a_login_skelet = p_crypto.Encrypt(y.a_login_skelet, dv_key);
                var o = await y.run(a.run());
                if (o.z_error == e_error.non)
                {
                    dv_key.id = o.deviceid;
                    db.Upsert(new m.data_item()
                    {
                        id = key_str,
                        data = p_crypto.convert(dv_key)
                    });
                    a.o2.c_key = dv_key;
                }
                else
                    throw new Exception("gkfvjghvfchfbvhgndc");
            }
            else
                a.o2.c_key = p_crypto.convert<m_key>(dv);
        }
    }
}