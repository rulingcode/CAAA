using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_1
{
    public class o1
    {
        public c_report report { get; set; }
        public void add_x(m_x endpoint) => a.s_x.add(endpoint);
        public Task<byte[]> run_c(m_x endpoint, byte[] data) => a.c_exchange.run(endpoint, data);
        public s_y y_s { get; set; }
        public void remove_c(m_x endpoint) => a.c_exchange.close(endpoint);
        public void remove_s(m_x endpoint) => a.s_x.remove(endpoint);
        o1() => a.o1 = this;
        public static o1 create() => a.o1 == null ? new o1() : null;
    }
}
