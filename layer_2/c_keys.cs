using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2
{
    class c_keys
    {
        internal static m_connect connect_m = default;
        static m_keys2[] list = new m_keys2[0];
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal static async Task<e_error> connect(m_connect val)
        {
            connect_m = val;
            return await add(o2.x_center);
        }
        static async Task<e_error> add(string xid)
        {
            await locker.WaitAsync();
            m_keys1 keys = z_crypto.create_symmetrical_keys();
            y_connect y = new y_connect();
            y.keys = z_crypto.combine(keys.key32, keys.iv16);
            y.keys = z_crypto.Encrypt(y.keys, a.o2.keys_c);
            y.m_connect = z_crypto.convert(connect_m);
            y.m_connect = z_crypto.Encrypt(y.m_connect, keys);
            var data = z_crypto.convert(y);
            var endpoint = await c_endpoint.get(xid);
            data = await a.o1.exchange_c(endpoint, data);
            var o = z_crypto.convert<y_connect.output>(data);
            if (o.z_error == e_error.non)
            {
                List<m_keys2> l = new List<m_keys2>(list);
                l.RemoveAll(i => i.xid == xid);
                l.Add(new m_keys2()
                {
                    xid = xid,
                    m_keys1 = keys
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
        public static async Task<m_keys1> get(string xid)
        {
            retry:
            var dv = list.FirstOrDefault(j => j.xid == xid);
            if (dv == null)
            {
                await add(xid);
                goto retry;
            }
            return dv.m_keys1;
        }
    }
}