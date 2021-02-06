using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace layer_1
{
    static class s_endpoint
    {
        static List<z_service> list = new List<z_service>();
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public static async void add(m_endpoint1 endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.endpoint == endpoint);
            if (dv != null)
            {
                dv.close();
                list.Remove(dv);
            }
            dv = new z_service(endpoint);
            list.Add(dv);
            locker.Release();
        }
        public static async void remove(m_endpoint1 endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.endpoint == endpoint);
            dv.close();
            list.Remove(dv);
            locker.Release();
        }
    }
}
