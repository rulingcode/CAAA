using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class c_user
    {
        List<string> list = new List<string>();
        internal async Task<e_error> add(string userid, string password)
        {
            y_login y = new y_login() { a_userid = userid, a_password = password };
            var o = await y.run_c(a.run());
            if (o.z_error == e_error.non)
                list.Add(userid);
            return o.z_error;
        }
        internal Task remove(string userid)
        {
            throw new NotImplementedException();
        }
    }
}
