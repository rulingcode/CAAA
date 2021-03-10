using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.x_center;
using MongoDB.Driver;

namespace layer_3.s
{
    class notify
    {
        public static async void send(string userid)
        {
            if (userid == "k" || userid.Substring(2, 3) == "any")
                a.api2.s_notify(null, userid);
            else
            {
                IEnumerable<sync_center> dv = default;
                dv = (await a.s_device_user.coll.FindAsync(i => i.users.Contains(userid))).ToEnumerable();
                foreach (var i in dv)
                    a.api2.s_notify(deviceid: i.id, userid: userid);
            }
        }
    }
}