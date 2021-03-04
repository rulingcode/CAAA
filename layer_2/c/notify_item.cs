using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WatsonTcp;

namespace layer_2.c
{
    class notify_item
    {
        bool reset = false;
        private const string connection_established = nameof(connection_established);
        WatsonTcpClient client;
        DateTime time = DateTime.Now.AddDays(-1);
        public m_xip xip { get; }
        public notify_item(m_xip xip)
        {
            this.xip = xip;
            live();
        }
        async void live()
        {
            TimeSpan timeSpan = TimeSpan.FromMilliseconds(5000 * 100);//9053
        retry:
            if ((DateTime.Now - time) > timeSpan)
                await connect();
            await Task.Delay(500);
            goto retry;
        }
        async Task connect()
        {
        retry:
            try
            {
                close_connection();
                client = new WatsonTcpClient(xip.address, xip.port + 1);
                client.Events.MessageReceived += Events_MessageReceived;
                await Task.Run(client.Connect);
                byte[] bfr = new byte[10];
                p_crypto.random.NextBytes(bfr);
                var key = a.api2.c_key;
                bfr = p_crypto.Encrypt(bfr, key);
                m_packet data = new()
                {
                    data = bfr,
                    deviceid = key.id,
                    xid = xip.id
                };
                bfr = p_crypto.convert(data);
                await client.SendAsync(bfr);
                time = DateTime.Now;
            }
            catch (Exception e)
            {
                goto retry;
            }
        }
        private void close_connection()
        {
            if (client == null) return;
            try
            {
                reset = false;
                client.Events.MessageReceived -= Events_MessageReceived;
                client.Dispose();
            }
            catch { }
            client = null;
        }
        async void Events_MessageReceived(object sender, MessageReceivedEventArgs e)
        {

            if (e.Data.Length == 1)
            {
                e_pulse pulse = (e_pulse)e.Data[0];
                if (pulse == e_pulse.s_live)
                {
                    time = DateTime.Now;
                    if (!reset)
                    {
                        a.c_notify.reset(xip.id);
                        reset = true;
                    }
                }
                else
                    throw new Exception("kdvjfjhsjcjfndj");
            }
            else
            {
                var dv = p_crypto.convert<m_notify>(e.Data);
                if (dv.xid != xip.id)
                    throw new Exception("ldkjjnjgnhdhvhgnbjf");
                if (dv.userid == null)
                    throw new Exception("kfjvjdvjfhfhshvfdhf");
                time = DateTime.Now;
                a.c_notify.c_notify(dv);
            }
            await Task.Delay(1000);
            await client.SendAsync(new byte[] { (byte)e_pulse.c_live });
        }
    }
}