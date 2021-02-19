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

namespace z_x_center.implement
{
    class device_registration : y_device_registration
    {

        protected override async void implement(s_reply2<output> reply)
        {
            a_key = p_crypto.Decrypt(a_key, private_key.data);
            m_key key = m_key.create(a_key);
            a_login = p_crypto.Decrypt(a_login, key);
            m_login m_login = p_crypto.convert<m_login>(a_login);
            if (!check_login(m_login))
                reply(new output() { z_error = e_error.invalid_device_info });
            var db = z_db.a_share<m_key>();
            key.id = ObjectId.GenerateNewId().ToString();
            await db.upsert(key);
            reply(new output() { deviceid = key.id });
        }
        private bool check_login(m_login m_Login) => m_Login.id == "k_windows" && m_Login.password == "kfkbjgjbhdjfjbjgjnjfjbg";
    }
}
