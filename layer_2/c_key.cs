using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2
{
    class c_key
    {
        private const string keyinfo = nameof(keyinfo);
        static m_key2[] list = new m_key2[0];
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public c_key()
        {
            start();
        }
        async void start()
        {
            await locker.WaitAsync();
            var dv = await a.o2.load_h(keyinfo);
            if (dv == null)
            {
                e_error error = await add(o2.x_center);
                if (error != e_error.non)
                {
                    await a.o2.report(new m_report()
                    {
                        errorid = "kjvjfhbhghvhfhvhdhc",
                        message = error.ToString()
                    });
                }
            }
            var key = z_crypto.convert<m_key2>(dv);
            list = new m_key2[] { key };
            locker.Release();
        }
        public async Task<m_key1> get(string xid)
        {
        retry:
            var dv = list.FirstOrDefault(j => j.xid == xid);
            if (dv == null)
            {
                await add(xid);
                goto retry;
            }
            return dv.key1;
        }
        async Task<e_error> add(string xid)
        {
            await locker.WaitAsync();
            m_key1 keys = z_crypto.create_symmetrical_keys();
            y_connect y = new y_connect();
            y.a_keys = m_key1.create(keys);
            y.a_keys = z_crypto.Encrypt(y.a_keys, a.o2.keys_c);
            y.a_connect = z_crypto.convert(await a.o2.connect_c());
            y.a_connect = z_crypto.Encrypt(y.a_connect, keys);
            var data = z_crypto.convert(y);
            var endpoint = await c_endpoint.get(xid);
            data = await a.o1.exchange_c(endpoint, data);
            var o = z_crypto.convert<y_connect.output>(data);
            if (o.z_error == e_error.non)
            {
                List<m_key2> l = new List<m_key2>(list);
                l.RemoveAll(i => i.xid == xid);
                l.Add(new m_key2()
                {
                    xid = xid,
                    key1 = keys
                });
                list = l.ToArray();
            }
            else
            {
                await a.o1.report(new m_report()
                {
                    errorid = "fjvjjhgjbfhcbdb",
                    message = "invalid connection_c"
                });
                await Task.Delay(100);
            }
            locker.Release();
            return o.z_error;
        }
    }
}