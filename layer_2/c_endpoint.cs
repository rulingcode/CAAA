using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2
{
    internal class c_endpoint
    {
        static m_endpoint2[] list = new m_endpoint2[0];
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal static async Task<m_endpoint1> get(string xid)
        {
            if (xid == o2.x_center)
                return a.o2.center_endpoint;
            retry:
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(j => j.xid == xid);
            locker.Release();
            if (dv == null)
            {
                await Task.Delay(100);
                y_getip y = new y_getip();
                var o = await y.run(a.o2.run_c(null));
                list = o.list;
                goto retry;
            }
            return dv;
        }
    }
}