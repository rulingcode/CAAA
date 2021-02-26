using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_user;

namespace z_x_user.z
{
    class upsert_name : y_upsert_name
    {
        protected async override void implement(s_reply<o> reply)
        {
            if (z_userid == a_userid)
            {
                var db = z_db.a_x<m.user>();
                var user = await db.get(z_userid);
                if (user == null)
                    user = new m.user() { id = z_userid };
                user.fullname = a_fullname;
                await db.upsert(user);
            }
            else
            {
                var db = z_db.a_user<m.user>(z_userid);
                if (a_userid != null && a_userid[0] != 'u')
                {

                }
            }
        }
    }
}
