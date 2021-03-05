using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class sync<T> : y_sync where T : m_sync
    {
        protected async override void implement(s_reply_o<o> reply)
        {
            var db = a.api3.s_db_factory(a.api3.s_xid).a_x<T>();
            var o = await db.get_history(a_time);
            reply(o);
        }
    }
}