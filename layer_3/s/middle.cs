﻿using layer_0;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using layer_0.cell;
using System.Linq;
using layer_0.x_center;

namespace layer_3.s
{
    internal class middle
    {
        internal async Task<e_error> run(y y)
        {
            if (y.z_userid != null)
            {
                sync_center dv = default;
                dv = await a.s_device_user.get(y.z_deviceid);
                if (dv == null)
                    return e_error.invalid_deviceid;
                if (!dv.users.Contains(y.z_userid))
                    return e_error.invalid_userid;
            }
            y.z_db = new db_factory(y.z_xid);
            y.z_db_c = a.c_db;
            return e_error.non;
        }
    }
}