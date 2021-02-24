﻿using layer_0;
using layer_3.data_model;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_3.s
{
    internal class middle
    {
        internal async Task<e_error> run(y y)
        {
            var db = a.share_db<m_device>();
            var dv = await db.get(y.z_deviceid);
            if (dv == null)
                return e_error.invalid_deviceid;
            if (dv.users.Contains(y.z_userid))
                return e_error.invalid_permission;
            y.z_db = new db_factory(y.z_xid);
            return e_error.non;
        }
    }
}