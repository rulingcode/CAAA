using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center.z
{
    class xlogin : y_xlogin
    {
        Dictionary<string, string> info = new Dictionary<string, string>();
        public xlogin()
        {
            info.Add("x_user", "1234");
        }
        protected async override void implement(s_reply<o> reply)
        {
            if (a_xid == null || a_password == null)
            {
                reply(new o() { z_error = e_error.invalid_parametrs });
                return;
            }
            var dv = info.GetValueOrDefault(a_xid);
            if (a_password == dv)
            {
                await a.add_user(z_deviceid, a_xid);
                reply();
            }
            else
                reply(new o() { z_error = e_error.invalid_parametrs });
        }
    }
}
