using layer_0;
using layer_1;
using System;
using System.Threading;
using System.Threading.Tasks;
using WatsonTcp;

namespace layer_1
{
    class c_questioner
    {
        public m_xip x_m { get; }
        public c_questioner(m_xip val) => x_m = val;

        WatsonTcpClient client;
        byte[] input = null;
        byte[] output = null;
        public bool inp { get; set; }
        public async Task<byte[]> send(byte[] data)
        {
            if (input != null)
                throw new Exception("ldkvbgdnvvkgxsk");
            input = data;
            return await send_chak();
        }
        DateTime time = DateTime.Now;
        TimeSpan timeout = TimeSpan.FromSeconds(100);//9053
        async Task<byte[]> send_chak()
        {
            bool in_send = false;
            await Task.Run(async () =>
            {
                time = DateTime.Now;
                while (output == null)
                {
                    TimeSpan timeout = DateTime.Now - time;
                    if (timeout >= this.timeout)
                    {
                        close();
                        in_send = false;
                    }
                    if (!in_send)
                    {
                        await send();
                        in_send = true;
                    }
                    await Task.Delay(1);
                }
            });
            var dv = output;
            input = output = null;
            return dv;
        }
        async Task send()
        {
            await locker.WaitAsync();
            retry:
            if (client != null && !client.Connected) close();
            if (client == null)
            {
                client = new WatsonTcpClient(x_m.address, x_m.port);
                client.Events.MessageReceived += Events_MessageReceived;
                try
                {
                    await Task.Run(client.Connect);
                }
                catch (Exception e)
                {
                    await a.o1.report?.Invoke(new m_report() { message = e.Message });
                    await Task.Delay(500);
                    goto retry;
                }
            }
            try
            {
                if (!await client.SendAsync(input))
                {
                    close();
                    goto retry;
                }
            }
            catch (Exception e)
            {
                await a.o1.report?.Invoke(new m_report()
                {
                    message = e.Message
                });
                goto retry;
            }
            locker.Release();
            time = DateTime.Now;
        }
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        async void Events_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            await locker.WaitAsync();
            if (sender == client)
                output = e.Data;
            locker.Release();
        }
        internal void close()
        {
            if (client?.Events != null)
            {
                client.Events.MessageReceived -= Events_MessageReceived;
            }
            try
            {
                client?.Dispose();
            }
            catch { }
            client = null;
        }
    }
}