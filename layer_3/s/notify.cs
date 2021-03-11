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
        public static async Task send(string userid)
        {
            if (userid == "ip" || userid == "device_update")
                a.api2.s_notify(null, userid);
            else
            {
                var all = await get_all_device(userid);
                foreach (var deviceid in all)
                    a.api2.s_notify(deviceid, userid);
            }
        }
        private static async Task<string[]> get_all_device(string userid)
        {
            return (await a.s_device_user.coll.FindAsync(i => i.users.Contains(userid))).ToEnumerable().Select(i => i.id).ToArray();
        }
    }
}