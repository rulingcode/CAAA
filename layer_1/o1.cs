using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_1
{
    public class o1
    {
        public h_report report { get; set; }
        public void add_s(m_x endpoint) => s_endpoint.add(endpoint);
        public Task<byte[]> exchange_c(m_x endpoint, byte[] data) => c_exchange.exchange(endpoint, data);
        public s_exchange exchange_s { get; set; }
        public void remove_c(m_x endpoint) => c_exchange.close(endpoint);
        public void remove_s(m_x endpoint) => s_endpoint.remove(endpoint);
        o1() => a.o1 = this;
        public static o1 create() => a.o1 == null ? new o1() : null;
    }
}
