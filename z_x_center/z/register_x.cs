using layer_0;
using layer_1;
using layer_2;
using layer_3;
using layer_0.x_center;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace z_x_center.z
{
    class register_x : y_register_x
    {
        protected override async void implement(s_reply_o<o> reply)
        {
            a_key_data = p_crypto.Decrypt(a_key_data, private_key.data);
            m_key key = m_key.create(a_key_data);
            a_register_data = p_crypto.Decrypt(a_register_data, key);
            var login = p_crypto.convert<m_register_x>(a_register_data);
            if (!await check_login(login))
            {
                reply(new o() { z_error = e_error.invalid_parametrs });
                return;
            }
            var db = z_db.a_x<m.device>();
            m.device device = new()
            {
                creation_time = DateTime.Now,
                id = "d_" + login.a_xid,
                iv16 = key.iv16,
                key32 = key.key32,
            };
            await db.upsert(device);
            await a.add_user(device.id, login.a_xid);
            reply(new o() { deviceid = device.id });
        }
        async Task<bool> check_login(m_register_x val)
        {
            if (val.a_xid.Substring(0, 2) != "x_")
                return false;
            var password = val.a_xid == "x_center" ? a.password : await a.get_password(val.a_xid);
            return val.a_password == password;
        }
    }
}