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
    class c_y
    {
        List<z_questioner_pool> list = new List<z_questioner_pool>();
        SemaphoreSlim n_locker = new SemaphoreSlim(12, 12);
        public async Task<byte[]> run(c_m_x x_m, byte[] data)
        {
            await n_locker.WaitAsync();
            var dv = await get(x_m);
            var rt = await dv.send(data);
            n_locker.Release();
            return rt;
        }

        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        async Task<z_questioner_pool> get(c_m_x val)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == val);
            if (dv == null)
            {
                dv = new z_questioner_pool(val);
                list.Add(dv);
            }
            locker.Release();
            return dv;
        }
        public async void close(c_m_x val)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.x_m == val);
            if (dv != null)
                dv.close();
            locker.Release();
        }
    }
}