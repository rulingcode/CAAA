using layer_0;
using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_0.all;

namespace layer_2
{
    class c_notify
    {
        UdpClient client = new UdpClient();
        List<item> list = new List<item>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        class item
        {
            public m_xip xip { get; set; }
            public DateTime time { get; set; }
        }
        public c_notify()
        {
            receiver();
            live();
        }
        async void live()
        {
        retry:
            await locker.WaitAsync();
            var dv = list.Where(i => DateTime.Now - i.time > TimeSpan.FromMilliseconds(5000)).ToArray();
            locker.Release();
            foreach (var i in dv)
                connect(i);
            await Task.Delay(250);
            goto retry;
        }
        async Task<item> get(string xid)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.xip.id == xid);
            locker.Release();
            return dv;
        }
        public async void add(string rsv)
        {

            await locker.WaitAsync();
            if (!list.Any(i => i.xip.id == rsv))
            {
                var dv = await a.x_c.get(rsv);
                list.Add(new item() { xip = dv, time = DateTime.Now.AddDays(-1) });
            }
            locker.Release();
        }
        async void connect(item rsv)
        {
            byte[] bfr = new byte[10];
            p_crypto.random.NextBytes(bfr);
            var key = await a.o2.c_get_key();
            bfr = p_crypto.Encrypt(bfr, key);
            send(rsv.xip, new c_data() { command = c_command.connect, data = bfr, deviceid = key.id });
            rsv.time = DateTime.Now;
        }
        async void send(m_xip xip, c_data data)
        {
            var dv = p_crypto.convert(data);
            await client.SendAsync(dv, dv.Length, xip.endpint);
        }
        async void receiver()
        {
        retry:
            var rcv = await client.ReceiveAsync();
            try
            {
                var data = p_crypto.convert<s_data>(rcv.Buffer);
                switch (data.command)
                {
                    case s_command.invalid_device:
                        {
                            await a.o2.c_report(new m_report()
                            {
                                errorid = "kjvjkduvfgjbhdfhfhjv",
                                message = "invalid device"
                            });
                        }
                        break;
                    case s_command.live:
                        {
                            var dv = await get(data.xid);
                            dv.time = DateTime.Now;
                        }
                        break;
                    case s_command.notify:
                        {
                            var dv = await get(data.xid);
                            dv.time = DateTime.Now;
                            send(dv.xip, new c_data() { command = c_command.received, message_id = data.mesageid });
                            a.o2.c_recive_notify?.Invoke(new m_notify()
                            {
                                xid = data.xid,
                                userid = data.userid
                            });
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                await a.o2.c_report(new m_report()
                {
                    errorid = "kjabjgjgjdjhfhjv",
                    message = e.Message
                });
            }
            goto retry;
        }
    }
}