using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2.c
{
    class notify
    {
        List<notify_item> list = new List<notify_item>();
        public void connect(m_xip[] rsv)
        {
            foreach (var i in rsv)
            {
                if (list.Any(i => i.xip == i.xip))
                    continue;
                list.Add(new notify_item(i));
            }
        }
    }
}
