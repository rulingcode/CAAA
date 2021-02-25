using layer_0;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;
using z_x_center.m;

namespace z_x_center.z
{
    class login : y_login
    {
        protected async override void implement(s_reply<output> reply)
        {
            if (a_password == null)
            {
                reply(new output() { a_error = error.invalid_params });
                return;
            }
            var db_user = z_db.a_x<user>();
            var user = await db_user.get(i => i.phoneid == a_phoneid);
            if (user == null || user.password != a_password)
            {
                reply(new output() { a_error = error.invalid_params });
                return;
            }
            user.password = null;
            await db_user.upsert(user);
            var db_device = z_db.a_x<device_users>();
            var device = await db_device.get(z_deviceid);
            if (device == null)
                device = new device_users() { id = z_deviceid };
            device.users.Remove(user.id);
            device.users.Add(user.id);
            await db_device.upsert(device);
            reply(new output() { userid = user.id });
        }
    }
}
