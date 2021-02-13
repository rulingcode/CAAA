using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using z_dna;

namespace z_center
{
    class message : y_message
    {
        protected override void implement(s_reply2<output> reply)
        {
            reply(new output() { c = a + b });
        }
    }
}
