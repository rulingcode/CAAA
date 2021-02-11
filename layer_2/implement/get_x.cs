using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2.implement
{
    class get_x : y_get_x
    {
        static output o = new output();
        protected override void implement(s_reply2<output> reply) => reply(o);
    }
}
