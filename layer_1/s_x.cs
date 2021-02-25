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
        public async void add(m_xip val)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == val);
            if (dv != null)
                throw new Exception("kgjjbjcjfjvds");
            dv = new s_service(val);
            list.Add(dv);
            locker.Release();
        }
        public async void remove(m_xip val)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == val);
            dv.close();
            list.Remove(dv);
            locker.Release();
        }
    }
}
