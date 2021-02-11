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
        const string keys = nameof(keys);
        List<m_key2> list = new List<m_key2>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public async void start()
        {
            await locker.WaitAsync();
            var dv = await a.o2.load(keys);
            if (dv == null)
            {
                e_error error = await add(o2.x_center);
                if (error != e_error.non)
                {
                    await a.o2.report_h(new m_report()
                    {
                        errorid = "kjvjfhbhghvhfhvhdhc",
                        message = error.ToString()
                    });
                }
            }
            else
            {
                var keys = z_crypto.convert<m_key2[]>(dv);
                list.AddRange(keys);
            }
            locker.Release();
        }
        public async Task<m_key1> get(string xid)
        {
            await locker.WaitAsync();
        retry:
            var dv = list.FirstOrDefault(j => j.xid == xid);
            if (dv == null)
            {
                await add(xid);
                goto retry;
            }
            locker.Release();
            return dv.key1;
        }
        async Task<e_error> add(string xid)
        {
            m_key1 keys = z_crypto.create_symmetrical_keys();
            y_connect y = new y_connect();
            y.a_keys = m_key1.create(keys);
            y.a_keys = z_crypto.Encrypt(y.a_keys, a.o2.key_c);
            m_login login_m = new m_login()
            {
                userid = a.o2.skeletid,
                password = await a.o2.get_password(a.o2.skeletid)
            };
            if (login_m.password == null)
                return e_error.no_find_password;
            y.a_login = z_crypto.convert(login_m);
            y.a_login = z_crypto.Encrypt(y.a_login, keys);
            var o = await y.run_c(a.o2.run());
            if (o.z_error == e_error.non)
            {
                list.Add(new m_key2()
                {
                    xid = xid,
                    key1 = keys
                });
                var data = z_crypto.convert(list.ToArray());

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
            return o.z_error;
        }
    }
}