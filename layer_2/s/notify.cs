using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WatsonTcp;

namespace layer_2.s
{
    class notify
    {
        List<item> list = new();
        SemaphoreSlim locker = new(1, 1);
        WatsonTcpServer server;
        public m_xip xip { get; }
        class item
        {
            public string deviceid { get; set; }
            public string ip { get; set; }
        }
        public notify(m_xip xip)
        {
            this.xip = xip;
            server = new(xip.address, xip.port + 1);
            server.Events.MessageReceived += Events_MessageReceived;
            server.Start();
        }
        public async void send(string deviceid, string userid)
        {
            switch (userid)
            {
                case "device_update":
                    {
                        await locker.WaitAsync();
                        var ips = list.Where(i => i.deviceid.Substring(0, 4) == "d_x_").Select(i => i.ip).ToArray();
                        locker.Release();
                        foreach (var i in ips)
                            direct_send("device_update", i);
                    }
                    break;
                case "ip":
                    {
                        await locker.WaitAsync();
                        var ips = list.Select(i => i.ip).ToArray();
                        locker.Release();
                        foreach (var i in ips)
                            direct_send("ip", i);
                    }
                    break;
                default:
                    {
                        await locker.WaitAsync();
                        var dv = list.FirstOrDefault(i => i.deviceid == deviceid);
                        locker.Release();
                        if (dv != null)
                            direct_send(userid, dv.ip);
                    }
                    break;
            }
        }
        async void direct_send(string userid, string ip)
        {
            m_notify notify = new() { userid = userid, xid = a.api2.s_xid };
            await server.SendAsync(ip, p_crypto.convert(notify));
        }
        async void Events_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            try
            {
                if (e.Data.Length == 1)
                {
                    e_pulse pulse = (e_pulse)e.Data[0];
                    if (pulse == e_pulse.c_live)
                        await server.SendAsync(e.IpPort, new byte[] { (byte)e_pulse.s_live });
                    else
                        server.DisconnectClient(e.IpPort);
                }
                else
                {
                    var dv = p_crypto.convert<m_packet>(e.Data);
                    var key = await a.api2.s_get_key(dv.deviceid);
                    dv.data = p_crypto.Decrypt(dv.data, key);
                    await locker.WaitAsync();
                    var item = list.FirstOrDefault(i => i.deviceid == dv.deviceid);
                    if (item == null)
                    {
                        item = new() { deviceid = dv.deviceid };
                        list.Add(item);
                    }
                    item.ip = e.IpPort;
                    locker.Release();
                    await server.SendAsync(e.IpPort, new byte[] { (byte)e_pulse.s_live });
                }
            }
            catch
            {
                server.DisconnectClient(e.IpPort);
            }
        }
        internal void close()
        {
            server.Dispose();
        }
    }
}