﻿using layer_1;
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
        public readonly c_m_x x_m;
        public z_service(c_m_x x_m)
        {
            this.x_m = x_m ?? throw new ArgumentNullException(nameof(x_m));
            server = new WatsonTcpServer(x_m.address, x_m.port);
            server.Events.MessageReceived += Events_MessageReceivedAsync;
            server.Start();
        }
        void Events_MessageReceivedAsync(object sender, MessageReceivedEventArgs e)
        {
            void met(byte[] answer, e_error reply) => this.answer(e.IpPort, reply, answer);
            a.o1.y_s.Invoke(e.Data, met);
        }
        private void answer(string ipPort, e_error error, byte[] data) => server.SendAsync(ipPort, data);
        public void close() => server.Dispose();
    }
}