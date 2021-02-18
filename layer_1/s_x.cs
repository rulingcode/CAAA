using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace layer_1
{
    class s_x
    {
        List<z_service> list = new List<z_service>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public async void add(c_m_x endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == endpoint);
            if (dv != null)
            {
                dv.close();
                list.Remove(dv);
            }
            dv = new z_service(endpoint);
            list.Add(dv);
            locker.Release();
        }
        public async void remove(c_m_x endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == endpoint);
            dv.close();
            list.Remove(dv);
            locker.Release();
        }
    }
}
