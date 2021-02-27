using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Driver;
using layer_1;
using layer_0;
using layer_0.cell;
using layer_0.x_center;

namespace layer_3.s
{
    class key
    {
        internal async Task<m_key> get(string deviceid)
        {
            if (a.o3.z_get_key != null)
                return await a.o3.z_get_key(deviceid);
            var coll = a.c_db.api<m_key>();
            var key = coll.FindOne(i => i.id == deviceid);
            if (key == null)
            {
                y_get_key y = new y_get_key()
                {
                    a_deviceid = deviceid
                };
                var o = await y.run(a.run("x_any"));
                if (o.z_error != e_error_base.non)
                    return null;
                key = o.m_key;
                coll.Upsert(key);
            }
            return key;
        }
    }
}
