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
        m_key m_key = null;
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async Task<m_key> get()
        {
            await locker.WaitAsync();
            if (m_key == null)
            {
                var dv = a.c_db.get(key_str);
                if (dv == null)
                {
                    y_device_registration y = new y_device_registration();
                    var dv_key = p_crypto.create_symmetrical_keys();
                    y.a_key = m_key.create(dv_key);
                    y.a_key = p_crypto.Encrypt(y.a_key, public_key.data);
                    m_login login_m = new m_login()
                    {
                        id = "k_windows",
                        password = "kfkbjgjbhdjfjbjgjnjfjbg"
                    };
                    y.a_login = p_crypto.convert(login_m);
                    y.a_login = p_crypto.Encrypt(y.a_login, dv_key);
                    var o = await y.run(a.run());
                    if (o.z_error == e_error.non)
                    {
                        dv_key.id = o.deviceid;
                        a.c_db.set(key_str, p_crypto.convert(dv_key));
                        m_key = dv_key;
                    }
                    else
                        throw new Exception("gkfvjghvfchfbvhgndc");
                }
                else
                {
                    m_key = p_crypto.convert<m_key>(dv);
                }
            }
            locker.Release();
            return m_key;
        }
    }
}
