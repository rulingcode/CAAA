using layer_0.cell;
using layer_0.x_center;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using z_x_center.m;

namespace z_x_center.z
{
    class send_code : y_send_code
    {

        protected async override void implement()
        {
            var db = z_db.general_x<user>();
            var dv = await db.get(i => i.phoneid == a_phoneid);
            if (dv == null)
            {
                dv = new user()
                {
                    phoneid = a_phoneid,
                    password = new_pass(),
                    id = "u_" + ObjectId.GenerateNewId()
                };
                await db.upsert(dv);
            }
            else
                if (dv.password == null)
            {
                dv.password = new_pass();
                await db.upsert(dv);
            }
            reply();
        }

        private static string new_pass()
        {
            return "12345";
        }
    }
}
