using layer_2;
using layer_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Driver;
using layer_1;
using layer_0;
using layer_0.x_center;

namespace z_x_center.implement
{
    class get_key : y_get_key
    {
        protected async override void implement(s_reply2<output> reply)
        {
            var db = a.o3.s_db.all<m_key>();
            var dv = await (await db.FindAsync(i => i.id == a_deviceid)).FirstOrDefaultAsync();
            if (dv == null)
                reply(new output() { z_error = e_error.invalid_deviceid });
            else
                reply(new output() { m_key = dv });
        }
    }
}
