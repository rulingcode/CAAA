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
        protected async override void implement()
        {
            await locker.WaitAsync();
            List<y_get_x.item> l = new(get_x.o.list);
            l.RemoveAll(i => i.xid == z_userid);
            l.Add(new y_get_x.item() { xid = z_userid, xip = a_xip });
            get_x.o.list = l.ToArray();
            locker.Release();
            reply();
            a.api3.s_notify("k");
        }
    }
}
