using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_service_center
{
    class y_test_imp : y_test
    {
        protected override void implement(s_reply2<o> reply)
        {
            reply(new o()
            {
                c = a + b
            });
        }
    }
}
