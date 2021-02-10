using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_1;

namespace layer_1
{
    static class c_exchange
    {
        static List<z_questioner> list = new List<z_questioner>();
        static SemaphoreSlim n_locker = new SemaphoreSlim(12, 12);
        public static async Task<byte[]> exchange(m_x endpoint, byte[] data)
        {
            await n_locker.WaitAsync();
            var dv = await get(endpoint);
            var rt = await dv.send(data);
            n_locker.Release();
            return rt;
        }

        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        static async Task<z_questioner> get(m_x endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.endpoint == endpoint);
            if (dv == null)
            {
                dv = new z_questioner(endpoint);
                list.Add(dv);
            }
            locker.Release();
            return dv;
        }
        public static async void close(m_x endpoint)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.endpoint == endpoint);
            if (dv != null)
                dv.close();
            locker.Release();
        }
    }
}