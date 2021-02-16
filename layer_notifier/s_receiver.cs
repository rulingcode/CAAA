using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace layer_notifier
{
    class s_receiver
    {
        private readonly IPEndPoint endpoint;
        UdpClient reciver;
        public s_receiver(IPEndPoint endpoint)
        {
            this.endpoint = endpoint;
            reciver = new UdpClient(endpoint);
            run();
        }
        async void run()
        {
        retry:
            var dv = await reciver.ReceiveAsync();
            run(dv);
            goto retry;
        }
        async void run(UdpReceiveResult val)
        {
            try
            {
                var dv = z_crypto.convert<c_data>(val.Buffer);
                switch (dv.command)
                {
                    case c_command.register_me:
                        {
                            a.sender_s.add(val.RemoteEndPoint, dv.str, dv.data);
                        }
                        break;
                    case c_command.i_was_informed:
                        {
                            a.sender_s.informed(dv.str);
                        }
                        break;
                }
            }
            catch
            {

            }
        }
    }
}
