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
        internal static s_db_factory db;
        static api3 api3f;
        static s_db<m_device_users> db_device_user;

        internal static key key;

        public static api3 api3
        {
            get => api3f;
            set
            {
                api3f = value;
                db = api3.s_db_factory("x_center");
                db_device_user = db.a_x<m_device_users>();
            }
        }
        internal static async Task add_user(string deviceid, string userid)
        {
            var dv = await db_device_user.get(deviceid);
            if (dv == null)
                dv = new m_device_users() { id = deviceid };
            dv.users.Remove(userid);
            dv.users.Add(userid);
            await a.db_device_user.upsert(dv);
            a.api3.s_notify("any_x");
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
                password = ObjectId.GenerateNewId().ToString()
            });
        }
    }
}
