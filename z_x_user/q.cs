﻿using layer_0.x_user;
using layer_x;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_user
{
    class q
    {
        public static async void delete(string owner, string userid) => await x.db.a_user<sync_user>(owner).delete(userid);
        public static async void update(string owner, m.user user)
        {
            sync_user dv = new()
            {
                gender = user.gender,
                id = user.id,
                is_contact = true,
                name = user.name,
                national_id = user.national_id,
                phoneid = user.phoneid,
                status = user.status
            };
            await x.db.a_user<sync_user>(owner).upsert(dv);
        }
        public static async void update(string owner, string userid)
        {
            var user = await x.db.a_x<m.user>().get(userid);
            update(owner, user);
        }
        internal static async Task update_all_contact(string userid)
        {
            var contact = await x.db.a_x<m.contact>().get(userid);
            var dv = contact.mine.Union(contact.partners).ToList();
            var user = await x.db.a_x<m.user>().get(userid);
            foreach (var i in dv)
                update(i, user);
        }
    }
}