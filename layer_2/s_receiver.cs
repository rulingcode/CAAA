using layer_0;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
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
                var dv = p_crypto.convert<c_data>(val.Buffer);
                switch (dv.command)
                {
                    case c_command.connect:
                        {
                            a.s_sender.connect(dv.xid, val.RemoteEndPoint, dv.deviceid, dv.data);
                        }
                        break;
                    case c_command.received:
                        {
                            a.s_sender.received(dv.message_id);
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
