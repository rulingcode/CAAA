using layer_0.cell;
using layer_0.x_center;
using layer_3;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center
{
    class a
    {
        internal static s_db_factory db => api3.s_db;
        internal static s_db<sync_center> db_device_user;
        internal static key key;
        public static api3 api3;
        internal static async Task add_user(string deviceid, string userid)
        {
            var dv = await db_device_user.get(deviceid);
            List<string> l = new List<string>();
            if (dv == null)
                dv = new sync_center() { id = deviceid };
            else
                l.AddRange(dv.users);
            l.Remove(userid);
            l.Add(userid);
            dv.users = l.ToArray();
            await a.db_device_user.upsert(dv);
            a.api3.s_notify("device_update");
        }
        public static async Task<string> get_password(string xid)
        {
            var db = a.db.a_x<m.info>();
            var dv = await db.get(xid);
            return dv?.password;
        }
        internal static void set_password(string xid)
        {
            var db = a.db.a_x<m.info>();
            db.upsert(new m.info()
            {
                id = xid,
                password = "qweasdzxc"
            });
        }
    }
}
