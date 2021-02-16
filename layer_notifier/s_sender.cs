using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace layer_notifier
{
    class s_sender
    {
        UdpClient sender = new UdpClient();
        List<device> list = new List<device>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        SemaphoreSlim locker2 = new SemaphoreSlim(1, 1);
        List<sent_item> list2 = new List<sent_item>();
        long n = 1;
        class device
        {
            public string endpont_str { get; set; }
            public IPEndPoint endpont { get; set; }
            public string deviceid { get; set; }
        }
        class sent_item
        {
            public byte[] data { get; set; }
            public string id { get; set; }
            public int n { get; set; }
            public IPEndPoint endpoint { get; set; }
            public DateTime time { get; set; }
        }
        public s_sender()
        {
            checker();
        }
        async void checker()
        {
            TimeSpan span = TimeSpan.FromMilliseconds(1000);
        retry:
            await locker2.WaitAsync();
            var dv = list2.Where(i => DateTime.Now - i.time > span).ToArray();
            foreach (var i in dv)
            {
                i.n++;
                send(i.endpoint, i.data);
                if (i.n >= 5)
                    list2.Remove(i);
            }
            locker2.Release();
            await Task.Delay(100);
            goto retry;
        }
        internal async void add(IPEndPoint endpoint, string deviceid, byte[] data)
        {
            var key = await a.o.get_key_s(deviceid);
            try
            {
                data = z_crypto.Decrypt(data, key);
                await locker.WaitAsync();
                var dv = list.FirstOrDefault();
                if (dv == null)
                {
                    dv = new device() { deviceid = deviceid };
                    list.Add(dv);
                }
                dv.endpont = endpoint;
                dv.endpont_str = endpoint.ToString();
                locker.Release();
                send(endpoint, new s_data() { command = s_command.live });
            }
            catch
            {
                send(endpoint, new s_data() { command = s_command.invalid_device });
            }
        }
        internal void send(IPEndPoint endPoint, s_data data)
        {
            byte[] dv = z_crypto.convert(data);
            send(endPoint, dv);
        }
        private async void send(IPEndPoint endPoint, byte[] dv)
        {
            await sender.SendAsync(dv, dv.Length, endPoint);
        }
        public async void send_notify(string xid, string userid, string command)
        {
            var dv = await a.o.get_all_device_s(userid);
            await locker.WaitAsync();
            var dev = list.Where(i => dv.Contains(i.deviceid)).ToArray();
            locker.Release();
            if (dev.Length != 0)
                foreach (var i in dev)
                    await send(xid, userid, command, i);
        }
        async Task send(string xid, string userid, string command, device i)
        {
            await locker2.WaitAsync();
            n++;
            var data = new s_data()
            {
                command = s_command.notify,
                id = n.ToString(),
                data = xid + "*" + userid + "*" + command
            };
            var item = new sent_item()
            {
                endpoint = i.endpont,
                id = data.id,
                data = z_crypto.convert(data),
                time = DateTime.Now
            };
            send(item.endpoint, item.data);
            list2.Add(item);
            locker2.Release();
        }
        internal async void informed(string id)
        {
            await locker2.WaitAsync();
            list2.RemoveAll(i => i.id == id);
            locker2.Release();
        }
    }
}