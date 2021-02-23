using layer_0.all;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WatsonTcp;

namespace layer_2.s
{
    class notify_item
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
        public notify_item(m_xip xip)
        {
            this.xip = xip;
            server = new(xip.address, xip.port + 1);
            server.Events.MessageReceived += Events_MessageReceived;
        }
        public async void send(string deviceid,string userid)
        {
            
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
                    var dv = p_crypto.convert<m_login_notify>(e.Data);
                    var key = await a.o2.s_get_key(dv.deviceid);
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
    }
}