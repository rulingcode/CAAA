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
    class device_registration : y_device_registration
    {
        protected override async void implement(s_reply<output> reply)
        {
            a_key = p_crypto.Decrypt(a_key, private_key.data);
            m_key key = m_key.create(a_key);
            a_login_skelet = p_crypto.Decrypt(a_login_skelet, key);
            m_login_skelet login = p_crypto.convert<m_login_skelet>(a_login_skelet);
            if (!await check_login(login))
            {
                reply(new output() { z_error = e_error.invalid_device_info });
                return;
            }
            var db = z_db.a_x<m.device>();
            m.device device = new()
            {
                creation_time = DateTime.Now,
                id = login.a_xid == null ? "d_" + ObjectId.GenerateNewId() : "d_" + login.a_xid,
                iv16 = key.iv16,
                key32 = key.key32,
                name = login.a_device_name
            };
            await db.upsert(device);
            reply(new output() { deviceid = device.id });
        }
        async Task<bool> check_login(m_login_skelet val)
        {
            if (val.a_password == null)
                return false;
            switch (val.a_skeletid)
            {
                case "center": return val.a_password == a.password;
                case "wpf_x":
                    {
                        var dv = val.a_password == await a.get_password(val.a_xid);
                        if (dv) await a.add_user("d_" + val.a_xid, val.a_xid);
                        return dv;
                    }
                case "wpf_skelet":
                    {
                        if (val.a_xid != null)
                            return false;
                        return val.a_password == "wpf_skelet_password";
                    }
            }
            throw new Exception("vkfkbgvjfgjvhdfjjbjg");
        }
    }
}