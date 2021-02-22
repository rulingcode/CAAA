using layer_0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using layer_0.all;

namespace layer_1
{
    public class o1
    {
        public c_report report { get; set; }
        public void add_x(m_xip endpoint) => a.s_x.add(endpoint);
        public Task<byte[]> run_c(m_xip endpoint, byte[] data) => a.y_c.run(endpoint, data);
        public s_y y_s { get; set; }
        public void remove_c(m_xip endpoint) => a.y_c.close(endpoint);
        public void remove_s(m_xip endpoint) => a.s_x.remove(endpoint);
        o1() => a.o1 = this;
        public static o1 create() => a.o1 == null ? new o1() : null;
    }
}
