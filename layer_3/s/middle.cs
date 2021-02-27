using layer_0;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_3.s
{
    internal class middle
    {
        internal async Task<e_error_base> run(y y)
        {
            if (y.z_userid != null)
            {
                if (a.o3.z_middle_y == null)
                {
                    var db = a.c_db.api<m.device_users>();
                    var dv = db.FindOne(i => i.id == y.z_deviceid);
                    if (dv == null)
                        return e_error_base.invalid_deviceid;
                    if (!dv.users.Contains(y.z_userid))
                        return e_error_base.invalid_permission;
                }
                else
                {
                    e_error_base rt = await a.o3.z_middle_y(y);
                    if (rt != layer_0.cell.e_error_base.non)
                        return rt;
                }
            }
            y.z_db = new db_factory(y.z_xid);
            return await Task.FromResult(e_error_base.non);
        }
    }
}