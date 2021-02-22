using layer_0;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using layer_0.all;

namespace layer_2
{
    class s_notify_sender
    {
        UdpClient sender = new UdpClient();
        List<device> device_list = new List<device>();
        SemaphoreSlim device_locker = new SemaphoreSlim(1, 1);
        SemaphoreSlim notify_locker = new SemaphoreSlim(1, 1);
        List<notify> notify_list = new List<notify>();
        long n = 1;
        class device
        {
            public IPEndPoint endpont { get; set; }
            public string deviceid { get; set; }
        }
        class notify
        {
            public byte[] data { get; set; }
            public string id { get; set; }
            public int n { get; set; }
            public IPEndPoint endpoint { get; set; }
            public DateTime time { get; set; }
        }
        public s_notify_sender()
        {
            checker();
        }
        async void checker()
        {
            TimeSpan span = TimeSpan.FromMilliseconds(1000);
        retry:
            await notify_locker.WaitAsync();
            var dv = notify_list.Where(i => DateTime.Now - i.time > span).ToArray();
            foreach (var i in dv)
            {
                i.n++;
                send(i.endpoint, i.data);
                if (i.n >= 5)
                    notify_list.Remove(i);
            }
            notify_locker.Release();
            await Task.Delay(100);
            goto retry;
        }
        internal async void connect(string xid, IPEndPoint ip, string deviceid, byte[] data)
        {
            var key = await a.o2.s_get_key(xid, deviceid);
            try
            {
                data = p_crypto.Decrypt(data, key);
                await device_locker.WaitAsync();
                var dv = device_list.FirstOrDefault();
                if (dv == null)
                {
                    dv = new device() { deviceid = deviceid };
                    device_list.Add(dv);
                }
                dv.endpont = ip;
                device_locker.Release();
                send(ip, new s_data() { command = s_command.live });
            }
            catch
            {
                send(ip, new s_data() { command = s_command.invalid_device });
            }
        }
        internal void send(IPEndPoint endPoint, s_data data)
        {
            byte[] dv = p_crypto.convert(data);
            send(endPoint, dv);
        }
        private async void send(IPEndPoint endPoint, byte[] dv)
        {
            await sender.SendAsync(dv, dv.Length, endPoint);
        }
        public async void send_notify(string xid, string userid, string command)
        {
            var dv = await a.o2.s_get_all_device(userid);
            await device_locker.WaitAsync();
            var dev = device_list.Where(i => dv.Contains(i.deviceid)).ToArray();
            device_locker.Release();
            if (dev.Length != 0)
                foreach (var i in dev)
                    await send(xid, userid, command, i);
        }
        async Task send(string xid, string userid, string command, device i)
        {
            await notify_locker.WaitAsync();
            n++;
            var data = new s_data()
            {
                command = s_command.notify,
                mesageid = n.ToString(),
                userid = xid + "*" + userid + "*" + command
            };
            var item = new notify()
            {
                endpoint = i.endpont,
                id = data.mesageid,
                data = p_crypto.convert(data),
                time = DateTime.Now
            };
            send(item.endpoint, item.data);
            notify_list.Add(item);
            notify_locker.Release();
        }
        internal async void received(string message_id)
        {
            await notify_locker.WaitAsync();
            notify_list.RemoveAll(i => i.id == message_id);
            notify_locker.Release();
        }
    }
}