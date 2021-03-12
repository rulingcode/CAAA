using layer_0.x_user;
using layer_x;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_user.z
{
    class upsert_contact : y_upsert_contact
    {
        protected async override void implement()
        {
            if (a_partner_id == null || a_partner_id == z_userid || a_partner_id[0] == 'b')
            {
                reply(new o() { a_error = error.invalid_parametrs });
                return;
            }
            if (await more.user(a_partner_id))
            {
                reply(new o() { a_error = error.invalid_partner_id });
                return;
            }
            await by_me();
            await partner();

            await z_db.user<sync_user>(z_userid).get(a_partner_id);
        }
        private async Task by_me()
        {
            var db = z_db.general_x<m.contact>();
            var contact = await db.get(z_userid);
            if (contact == null)
                contact = new m.contact() { id = z_userid };
            contact.by_me.Remove(a_partner_id);
            if (a_contact)
                contact.by_me.Add(a_partner_id);
            await db.upsert(contact);

            if (a_contact)
                q.update(z_userid, a_partner_id);
            else
                q.delete(z_userid, a_partner_id);
        }
        private async Task partner()
        {
            var db = z_db.general_x<m.contact>();
            var contact = await db.get(a_partner_id);
            if (contact == null)
                contact = new m.contact() { id = a_partner_id };
            contact.by_them.Remove(a_partner_id);
            if (a_contact)
                contact.by_them.Add(a_partner_id);
            await db.upsert(contact);
        }
    }
}
