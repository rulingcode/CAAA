using layer_0.cell;
using layer_0.x_user;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_user.z
{
    class upsert_info : y_upsert_info
    {
        protected override void implement()
        {
            if (a_userid != null && a_userid != z_userid && a_userid[0] != 'b')
            {
                reply(new o() { a_error = error.permission_required });
                return;
            }
            if (a_userid == null || a_userid[0] == 'b')
                subsidiary(reply);
            else
                independent(reply);
        }
        async void independent(s_reply_o<o> reply)
        {
            var db = z_db.a_x<m.user>();
            if (a_status > e_status.independent)
            {
                reply(new o() { a_error = error.permission_required });
                return;
            }
            var user = await db.get(i => i.full_name == a_full_name && i.status > e_status.independent);
            if (user != null && user.id != a_userid)
            {
                reply(new o() { a_error = error.duplicate_name });
                return;
            }
        }
        private void subsidiary(s_reply_o<o> reply)
        {

        }
    }
}