using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_1
{
    public class o1
    {
        internal static byte[] null_data = new byte[] { 101, 58, 230, 77, 33, 59, 15, 9, 88, 165 };
        public h_report report { get; set; }
        public void add_s(m_x1 endpoint) => s_endpoint.add(endpoint);
        public Task<byte[]> exchange_c(m_x1 endpoint, byte[] data) => c_exchange.exchange(endpoint, data);
        public s_exchange exchange_s { get; set; }
        public void remove_c(m_x1 endpoint) => c_exchange.close(endpoint);
        public void remove_s(m_x1 endpoint) => s_endpoint.remove(endpoint);
        o1() => a.o1 = this;
        public static o1 create() => a.o1 == null ? new o1() : null;
    }
}
