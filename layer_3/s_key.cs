using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3
{
    class s_key
    {
        long n = 0;
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async Task<m_key> get(string deviceid)
        {
            await locker.WaitAsync();
            locker.Release();
        }
    }
}
