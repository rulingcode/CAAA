using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2.implement
{
    class set_x : y_set_x
    {
        static SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        protected async override void implement(s_reply2<output> reply)
        {
            await locker.WaitAsync();
            List<m_x> l = new List<m_x>(get_x.o.list);
            l.Add(a_x_m);
            locker.Release();
        }
    }
}
