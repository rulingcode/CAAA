﻿using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;
using layer_0.x_center;

namespace layer_2.c
{
    class x
    {
        m_xip[] list = new m_xip[0];
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async Task<m_xip> get(string xid)
        {
            if (xid == "x_center")
                return a.api2.c_xip;
            retry:
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(j => j.id == xid);
            locker.Release();
            if (dv == null)
            {
                await Task.Delay(100);
                goto retry;
            }
            return dv;
        }
        internal async void set(m_xip[] val)
        {
            await locker.WaitAsync();
            list = val;
            locker.Release();
        }
    }
}