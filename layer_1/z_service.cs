using layer_1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WatsonTcp;

namespace layer_1
{
    class z_service
    {
        WatsonTcpServer server;
        public readonly m_endpoint1 endpoint;
        public z_service(m_endpoint1 serverip)
        {
            this.endpoint = serverip ?? throw new ArgumentNullException(nameof(serverip));
            server = new WatsonTcpServer(serverip.address, serverip.port);
            server.Events.MessageReceived += Events_MessageReceivedAsync;
            server.Start();
        }
        void Events_MessageReceivedAsync(object sender, MessageReceivedEventArgs e)
        {
            var data = o1.null_data.SequenceEqual(e.Data) ? null : e.Data;
            void reply_h(byte[] answer, e_reply reply) => this.answer(e.IpPort, reply, answer);
            a.o1.exchange_s.Invoke(data, reply_h);
        }
        private void answer(string ipPort, e_reply reply, byte[] data)
        {
            data = data == null ? o1.null_data : data;
            server.SendAsync(ipPort, data);
        }
        public void close() => server.Dispose();
    }
}