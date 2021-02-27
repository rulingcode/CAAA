using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace layer_3.c
{
    internal class middle
    {
        List<string> users = new List<string>();
        internal async Task<e_error> besfor(y y)
        {
            return default;
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
                            users.Remove(dvo.a_userid);
                            users.Add(dvo.a_userid);
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
                            users.Remove(dv.a_xid);
                            users.Add(dv.a_xid);
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
    }
}