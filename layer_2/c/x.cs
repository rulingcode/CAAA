using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_center;

namespace layer_2.c
{
    class x
    {
        y_get_x.item[] list = new y_get_x.item[0];
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async Task<m_xip> get(string xid)
        {
            if (xid == "x_center")
                return a.api2.c_xip;
            retry:
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(j => j.xid == xid);
            locker.Release();
            if (dv == null)
            {
                await Task.Delay(100);
                goto retry;
            }
            return dv.xip;
        }
        internal async void set(y_get_x.item[] list)
        {
            await locker.WaitAsync();
            this.list = list;
            locker.Release();
        }
    }
}