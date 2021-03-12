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
    class register_c : y_register_c
    {
        protected override async void implement()
        {
            a_key_data = p_crypto.Decrypt(a_key_data, private_key.data);
            m_key key = m_key.create(a_key_data);
            a_register_data = p_crypto.Decrypt(a_register_data, key);
            m_register_c login = p_crypto.convert<m_register_c>(a_register_data);
            if (!await check_login(login))
            {
                reply(new o() { z_error = e_error.invalid_device_info });
                return;
            }
            var db = z_db.general_x<m.device>();
            m.device device = new()
            {
                creation_time = DateTime.Now,
                id = "d_" + ObjectId.GenerateNewId(),
                iv16 = key.iv16,
                key32 = key.key32,
                name = login.a_device_name
            };
            await db.upsert(device);
            reply(new o() { deviceid = device.id });
        }
        async Task<bool> check_login(m_register_c val)
        {
            await Task.CompletedTask;
            return val.a_skeletid == "wpf_skeleton" && val.a_password == "1234";
        }
    }
}