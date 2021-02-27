using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_center;

namespace z_x_center.z
{
    class set_x : y_set_x
    {
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        protected async override void implement(s_reply<o> reply)
        {
            if (a_xip.id != z_userid)
            {
                reply(new o() { z_error = e_error_base.invalid_xid });
                return;
            }
            await locker.WaitAsync();
            List<m_xip> l = new List<m_xip>(get_x.o.list);
            l.Remove(a_xip);
            l.Add(a_xip);
            get_x.o.list = l.ToArray();
            locker.Release();
            reply();
        }
    }
}
