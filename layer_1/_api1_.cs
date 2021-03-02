using layer_0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_1
{
    class _api1_ : api1
    {
        s.exchange service;
        public c_report c_report { get; set; }
        public Task<byte[]> c_exchange(m_xip val, byte[] data) => a.c_exchange.run(val, data);
        public s_exchange s_exchange { get; set; }
        public m_xip s_xip
        {
            get => service?.x_m;
            set
            {
                if (service != null)
                    service.close();
                service = new s.exchange(value);
            }
        }
        internal _api1_()
        {
            a.api1 = this;
            a.c_exchange = new c.exchange();
        }
    }
}