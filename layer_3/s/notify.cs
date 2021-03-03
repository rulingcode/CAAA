using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;

namespace layer_3.s
{
    class notify
    {
        public static async void send(string userid)
        {
            if (userid.Substring(2, 3) == "any")
                a.api2.s_notify(null, userid);
            else
            {
                var dv = await a.db_device_user.coll.FindAsync(i => i.users.Contains(userid));
                var l = (await dv.ToListAsync());
                foreach (var i in l)
                    a.api2.s_notify(i.id, userid);
            }
        }
    }
}