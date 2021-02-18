using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2.implement
{
    class get_x : y_get_x
    {
        internal static output o = new output() { list = new c_m_x[0] };
        protected override void implement(s_reply2<output> reply) => reply(o);
    }
}
