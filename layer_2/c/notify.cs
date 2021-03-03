using layer_0.cell;
using layer_0.x_center;
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
        internal void c_notify(m_notify notify)
        {
            if (notify.xid == "x_center")
                reload(notify.userid);
            else
                a.o2.c_notify?.Invoke(notify);
        }
        async void reload(string userid)
        {
            y_get_x y = new();
            var o = await y.run(a.o2.c_run());
            foreach (var i in o.list)
            {
                if (list.Any(j => i == j.xip))
                    continue;
                list.Add(new notify_item(i));
            }
        }
        internal void connect()
        {
            list.Add(new notify_item(a.o2.c_xip));
            
        }
        internal void reset(string xid)
        {
            if (xid == "x_center")
                c_notify(new m_notify() { xid = xid, userid = "reset" });
        }
    }
}