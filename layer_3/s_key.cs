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
using layer_0.x_center;

namespace layer_3
{
    class s_key
    {
        internal async Task<m_key> get(string xid, string deviceid)
        {
            var coll = a.s_db.all<m_key>();
            var key = await (await coll.FindAsync(j => j.id == deviceid)).FirstOrDefaultAsync();
            if (key == null)
            {
                y_get_key y = new y_get_key()
                {
                    a_deviceid = deviceid
                };
                var o = await y.run_c(a.run(xid));
                if (o.z_error != e_error.non)
                    return null;
                key = o.m_key;
                coll.ReplaceOne(i => i.id == deviceid, key);
            }
            return key;
        }
    }
}
