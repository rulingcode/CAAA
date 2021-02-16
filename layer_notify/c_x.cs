using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading;

namespace layer_3
{
    internal class c_x
    {
        List<c_udp> list = new List<c_udp>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async void add(m_x x_m)
        {
            await locker.WaitAsync();
            if (list.Any(i => i.x_m.data == x_m.data))
                throw new Exception("kvjfjbhghvhdd");
                list.Add(new c_udp(x_m));
            locker.Release();
        }
    }
}