using layer_0;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using layer_0.cell;
using System.Linq;

namespace layer_3.s
{
    internal class middle
    {
        internal async Task<e_error> run(y y)
        {
            if (y.z_userid != null)
            {
                var dv = await a.db_device_user.get(y.z_deviceid);
                if (dv == null)
                    return e_error.invalid_deviceid;
                if (!dv.users.Contains(y.z_userid))
                    return e_error.invalid_userid;
            }
            y.z_db = new db_factory(y.z_xid);
            return e_error.non;
        }
    }
}