using layer_0.cell;
using layer_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center
{
    class a
    {
        static s_db_factory db;
        static api3 api3f;
        static s_db<m.device_users> device_user;
        internal static string password;
        public static api3 o3
        {
            get => api3f;
            set
            {
                api3f = value;
                db = o3.s_db_factory("x_center");
                device_user = db.a_x<m.device_users>();
            }
        }
        internal static async Task add_user(string deviceid, string userid)
        {
            var dv = await a.device_user.get(deviceid);
            if (dv == null)
                dv = new m.device_users() { id = deviceid };
            dv.users.Remove(userid);
            dv.users.Add(userid);
            await a.device_user.upsert(dv);
        }
        public static async Task<e_error> middle_y(y y)
        {
            var dv = await device_user.get(y.z_deviceid);
            if (dv == null)
                return e_error.invalid_deviceid;
            if (y.z_userid == "x_any")
                return dv.users.Any(i => i.Substring(0, 2) == "x_") ? e_error.non : e_error.invalid_permission;
            else
                return dv.users.Contains(y.z_userid) ? e_error.non : e_error.invalid_userid;
        }
        public static async Task<string> get_password(string xid)
        {
            var db = a.db.a_x<m.info>();
            var dv = await db.get(xid);
            return dv?.password;
        }
    }
}
