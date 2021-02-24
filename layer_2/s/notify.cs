using layer_0.cell;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2.s
{
    class notify
    {
        List<notify_item> list = new List<notify_item>();
        SemaphoreSlim locker = new(1, 1);
        public async void add(m_xip xip)
        {
            notify_item dv = new(xip);
            await locker.WaitAsync();
            list.Add(dv);
            locker.Release();
        }
        internal async void send(string xid, string deviceid, string userid)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.xip.id == xid);
            if (dv == null)
                throw new Exception("fkbkgfdkvkgbkfkd");
            locker.Release();
            dv.send(deviceid, userid);
        }
    }
}
