using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_test
{
    class test : y_test
    {
        protected override void implement(s_reply2<output> reply)
        {
            reply(new output() { c = a + b });
        }
    }
}
