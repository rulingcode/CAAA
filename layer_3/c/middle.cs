using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3.c
{
    internal class middle
    {
        List<string> users = new List<string>();
        SemaphoreSlim locker = new(1, 1);
        public middle()
        {
            var dv = a.c_db.api<m_data>().get(i => i.id == "users")?.data;
            if (dv != null)
                users = p_crypto.convert<List<string>>(dv);
        }
        internal async Task<e_error> besfor(y y)
        {
            return await Task.FromResult(e_error.non);
        }
        internal async Task after(y y, o_base o)
        {
            switch (y)
            {

            }
            await Task.CompletedTask;
        }
    }
}