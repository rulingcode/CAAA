using layer_0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_1
{
    public class o1 : Io1
    {
        s_service service;
        public c_report report { get; set; }
        public Task<byte[]> run_c(m_xip val, byte[] data) => a.c_y.run(val, data);
        public s_y y_s { get; set; }
        public m_xip s_xip
        {
            get => service?.x_m;
            set
            {
                if (service != null)
                    service.close();
                service = new s_service(value);
            }
        }
        o1()
        {
            a.o1 = this;
            a.c_y = new c_y();
        }
        public static o1 create() => a.o1 == null ? new o1() : null;
    }
}