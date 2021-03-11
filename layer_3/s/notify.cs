using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_center;
using MongoDB.Driver;

namespace layer_3.s
{
    class notify
    {
        public static async Task send(string userid)
        {
            if (userid == all_command.address_updated || userid == all_command.device_updated)
                a.api2.s_notify(null, userid);
            else
            {
                var all_device = await get_all_device(userid);
                foreach (var device in all_device)
                    a.api2.s_notify(device, userid);
            }
        }
        private static async Task<string[]> get_all_device(string userid)
        {
            return (await a.s_device_user.coll.FindAsync(i => i.users.Contains(userid))).ToEnumerable().Select(i => i.id).ToArray();
        }
    }
}