using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2.s
{
    class notify
    {
        List<notify_item> list = new List<notify_item>();
        public void add(m_xip xip)
        {
            notify_item dv = new(xip);
            list.Add(dv);
        }

        internal void send(string xid, string deviceid, string userid)
        {
            throw new NotImplementedException();
        }
    }
}
