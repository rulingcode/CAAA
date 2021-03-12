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
            if (a_name == null || a_name.Length < 5)
            {
                reply(new o() { a_error = error.invalid_name });
                return;
            }
            if (a_userid == null || a_userid[0] == 'b')
                virtual_person();
            else
         if (a_userid[0] == 'u')
                real_person();
            else
                reply(new o() { a_error = error.invalid_userid });
        }
        private void virtual_person()
        {

        }
        async void real_person()
        {
            if (a_state == e_status.subsidiary)
            {
                reply(new o() { a_error = error.invalid_state });
                return;
            }
            var db = z_db.general_x<m.user>();
            var user = await db.get(a_userid);
            if (user == null)
                user = new m.user() { id = a_userid };

            var max_state = (e_status)Math.Max((byte)a_state, (byte)user.status);
            bool license_requerd = max_state > e_status.independent || a_userid != z_userid;

            if (license_requerd && (await z_license()) == e_license.normal)
            {
                reply(new o() { a_error = error.license_required });
                return;
            }
            user.name = a_name;
            user.gender = a_gender;
            user.national_id = a_national_code;
            user.phoneid = a_phoneid;
            user.status = a_state;
            await db.upsert(user);
            await q.update_all_contact_by_them(a_userid);
            reply(new o() { a_error = error.non });
        }
    }
}