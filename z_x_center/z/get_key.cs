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
using layer_0.cell;
using layer_0.x_center;

namespace z_x_center.z
{
    class get_key : y_get_key
    {
        protected async override void implement(s_reply_o<output> reply)
        {
            var dv = await get(a_deviceid);
            if (dv == null)
                reply(new output() { z_error = e_error.invalid_deviceid });
            else
                reply(new output() { m_key = dv });
        }
        public static async Task<m_key> get(string deviceid)
        {
            var db = a.o3.s_db_factory("x_center").a_x<m.device>();
            var dv = await db.get(deviceid);
            return dv == null ? null : new m_key()
            {
                id = dv.id,
                iv16 = dv.iv16,
                key32 = dv.key32
            };
        }
    }
}
