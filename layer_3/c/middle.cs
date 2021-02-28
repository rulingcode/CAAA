using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3.c
{
    internal class middle
    {
        List<string> users = new List<string>();
        SemaphoreSlim locker = new(1, 1);
        public middle()
        {
            var dv = a.c_db.api<m.data_item>().FindOne(i => i.id == "users")?.data;
            if (dv != null)
                users = p_crypto.convert<List<string>>(dv);
        }
        internal async Task<e_error> besfor(y y)
        {
            if (y.z_userid == null)
                return e_error.non;
            await locker.WaitAsync();
            var dv = users.Contains(y.z_userid);
            locker.Release();
            if (dv)
                return e_error.non;
            else
            {
                if (y.z_userid[0] != 'u')
                    return e_error.invalid_userid;
                var password = await a.o3.c_get_password(y.z_userid);
                y_phone_login y = new()
                {
                    
                };
            }
        }
        internal async Task after(y y, o_base o)
        {
            switch (y)
            {
                case y_phone_login dv:
                    {
                        var dvo = o as y_phone_login.o;
                        if (dvo.z_error == e_error.non)
                        {
                            await add_user(dvo.a_userid);
                            a.c_db.api<m.data_item>().Upsert(new m.data_item()
                            {
                                id = "users",
                                data = p_crypto.convert(users)
                            });
                        }
                    }
                    break;
                case y_xlogin dv:
                    {
                        var dvo = o as y_xlogin.o;
                        if (dvo.z_error == e_error.non)
                        {
                            await add_user(dv.a_xid);
                            a.c_db.api<m.data_item>().Upsert(new m.data_item()
                            {
                                id = "users",
                                data = p_crypto.convert(users)
                            });
                        }
                    }
                    break;
            }
            await Task.CompletedTask;
        }

        private async Task add_user(string userid)
        {
            await locker.WaitAsync();
            users.Remove(userid);
            users.Add(userid);
            locker.Release();
        }
    }
}