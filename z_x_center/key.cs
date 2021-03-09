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
using LiteDB;

namespace z_x_center
{
    class key
    {
        internal e_error connect()
        {
            var db = a.api3.c_db.api<m_data>();
            var dv = db.get(i => i.id == "key")?.data;
            if (dv == null)
                return e_error.null_c_key;
            else
            {
                a.api3.c_key = p_crypto.convert<m_key>(dv);
                return e_error.non;
            }
        }
        internal async Task<e_error> connect(string password)
        {
            y_register_x y = new();
            var dv_key = p_crypto.create_symmetrical_keys();
            y.a_key_data = m_key.create(dv_key);
            y.a_key_data = p_crypto.Encrypt(y.a_key_data, public_key.data);
            var login_m = new m_register_x()
            {
                a_xid = "x_center",
                a_password = password
            };
            y.a_register_data = p_crypto.convert(login_m);
            y.a_register_data = p_crypto.Encrypt(y.a_register_data, dv_key);
            var o = await y.run(a.api3.c_run());
            if (o.z_error == e_error.non)
            {
                dv_key.id = o.deviceid;
                var db = a.api3.c_db.api<m_data>();
                db.upsert(new m_data()
                {
                    id = "key",
                    data = p_crypto.convert(dv_key)
                });
                a.api3.c_key = dv_key;
            }
            return o.z_error;
        }
        internal void disconnect()
        {
            a.api3.c_db.api<m_data>().delete("key");
            a.api3.c_key = null;
        }
    }
}