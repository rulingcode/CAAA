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
        internal e_error connect()
        {
            var db = a.c_db.api<m_data_item>();
            var dv = db.get(i => i.id == key_str)?.data;
            if (dv == null)
                return e_error.null_c_key;
            else
            {
                a.o2.c_key = p_crypto.convert<m_key>(dv);
                return e_error.non;
            }
        }
        internal async Task<e_error> connect(string skeletid, string password, string xid = null)
        {
            y_device_registration y = new y_device_registration();
            var dv_key = p_crypto.create_symmetrical_keys();
            y.a_key = m_key.create(dv_key);
            y.a_key = p_crypto.Encrypt(y.a_key, public_key.data);
            m_login_skelet login_m = new m_login_skelet()
            {
                a_skeletid = skeletid,
                a_password = password,
                a_xid = xid,
                a_device_name = Environment.MachineName
            };
            y.a_login_skelet = p_crypto.convert(login_m);
            y.a_login_skelet = p_crypto.Encrypt(y.a_login_skelet, dv_key);
            var o = await y.run(a.run());
            if (o.z_error == e_error.non)
            {
                dv_key.id = o.deviceid;
                var db = a.c_db.api<m_data_item>();
                db.upsert(new m_data_item()
                {
                    id = key_str,
                    data = p_crypto.convert(dv_key)
                });
                a.o2.c_key = dv_key;
            }
            return o.z_error;
        }
    }
}