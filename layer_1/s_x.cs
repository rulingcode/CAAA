using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using layer_0.cell;

namespace layer_1
{
    class s_x
    {
        List<s_service> list = new List<s_service>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public async void add(m_xip endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == endpoint);
            if (dv != null)
            {
                dv.close();
                list.Remove(dv);
            }
            dv = new s_service(endpoint);
            list.Add(dv);
            locker.Release();
        }
        public async void remove(m_xip endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == endpoint);
            dv.close();
            list.Remove(dv);
            locker.Release();
        }
    }
}
