using layer_1;
using layer_2.implement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    class s_x
    {
        internal async void add_x(m_x rsv)
        {
            if (rsv.id == a.o2.x_m.id)
            {
                a.o2.add_y<get_x>();
                a.o2.add_y<set_x>();
            }
            a.o1.add_s(rsv);
            if (rsv.id != a.o2.x_m.id)
            {
                y_set_x y = new y_set_x()
                {
                    a_x_m = rsv
                };
                var dv = await y.run_c(a.o2.run());
                if (dv.z_error != e_error.non)
                    throw new Exception("lfvhfnbgnvnndn");
            }
        }
    }
}
