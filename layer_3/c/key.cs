﻿using layer_0;
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
        internal async Task connect()
        {
            var dv = a.c_db.get(key_str);
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
                    device_name = Environment.MachineName
                };
                y.a_login_skelet = p_crypto.convert(login_m);
                y.a_login_skelet = p_crypto.Encrypt(y.a_login_skelet, dv_key);
                var o = await y.run(a.run());
                if (o.z_error == e_error.non)
                {
                    dv_key.id = o.deviceid;
                    a.c_db.set(key_str, p_crypto.convert(dv_key));
                    a.o2.c_key = dv_key;
                }
                else
                    throw new Exception("gkfvjghvfchfbvhgndc");
            }
            else
            {
                a.o2.c_key = p_crypto.convert<m_key>(dv);
            }
        }
    }
}