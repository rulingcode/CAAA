using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    class c_udp
    {
        UdpClient client = new UdpClient();
        DateTime last_receive = DateTime.Now.AddDays(-1);
        public m_x x_m { get; }
        public c_udp(m_x x_m)
        {
            this.x_m = x_m;
            receiver();
            live();
        }

        async void live()
        {
        retry:
            if (DateTime.Now - last_receive > TimeSpan.FromSeconds(5))
            {
                byte[] bfr = new byte[10];
                z_crypto.random.NextBytes(bfr);
                var key = await a.o3.get_key_c();
                bfr = z_crypto.Encrypt(bfr, key);
                send(new c_data() { command = c_command.register_me, data = bfr, str = key.deviceid });
            }
            await Task.Delay(1000);
            goto retry;
        }
        async void send(c_data data)
        {
            var dv = z_crypto.convert(data);
            await client.SendAsync(dv, dv.Length, x_m.endpint);
        }
        async void receiver()
        {
        retry:
            var rcv = await client.ReceiveAsync();
            try
            {
                var data = z_crypto.convert<s_data>(rcv.Buffer);
                switch (data.command)
                {
                    case s_command.invalid_device:
                        {
                            await a.o3.report_c(new m_report()
                            {
                                errorid = "kjvjkduvfgjbhdfhfhjv",
                                message = "invalid device"
                            });
                        }
                        break;
                    case s_command.live:
                        {
                            last_receive = DateTime.Now;
                        }
                        break;
                    case s_command.notify:
                        {
                            var dv = data.data.Split('*');
                            if (dv.Length != 3)
                            {
                                await a.o3.report_c(new m_report()
                                {
                                    errorid = "kjkdkvjfhbjhfhjv",
                                    message = "invalid notify format",
                                    value = data.data
                                });
                            }
                            else
                            {
                                send(new c_data() { command = c_command.i_was_informed, str = data.id });
                                a.o3.recive_notify_c?.Invoke(dv[0], dv[1], dv[2]);
                            }
                        }
                        break;
                }
            }
            catch (Exception e)
            {
                await a.o3.report_c(new m_report()
                {
                    errorid = "kjabjgjgjdjhfhjv",
                    message = e.Message
                });
            }
            goto retry;
        }
    }
}