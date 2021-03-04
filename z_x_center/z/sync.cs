using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center.z
{
    class sync : y_sync
    {
        protected async override void implement(s_reply_o<o> reply)
        {
            var db = a.db.a_x<m_device_users>();
            var o = await db.get_history(a_time);
            reply(o);
        }
    }
}
