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
            m_login_skelet m_login = p_crypto.convert<m_login_skelet>(a_login_skelet);
            if (!check_login(m_login))
                reply(new output() { z_error = e_error_base.invalid_device_info });
            var db = z_db.a_x<m.device>();
            m.device device = new()
            {
                creation_time = DateTime.Now,
                id = "d_" + ObjectId.GenerateNewId(),
                iv16 = key.iv16,
                key32 = key.key32,
                name = m_login.device_name
            };
            await db.upsert(device);
            reply(new output() { deviceid = device.id });
        }
        private bool check_login(m_login_skelet m_Login) => m_Login.skelet_id == "k_windows" && m_Login.password == "kfkbjgjbhdjfjbjgjnjfjbg";
    }
}
