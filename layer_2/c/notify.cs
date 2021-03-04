﻿using layer_0.cell;
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
            if (notify.xid == "x_center" && notify.userid == "u_any")
                u_any();
            else
                a.api2.c_notify?.Invoke(notify);
        }
        async void u_any()
        {
            y_get_x y = new();
            var o = await y.run(a.run_null);
            a.c_x.set(o.list);
            foreach (var i in o.list)
            {
                if (list.Any(j => i.xid == j.xid))
                    continue;
                list.Add(new notify_item(i.xid, i.xip));
            }
        }
        internal void connect()
        {
            list.Add(new notify_item(a.api2.s_xid, a.api2.c_xip));
        }
        internal void reset(string xid)
        {
            if (xid == "x_center")
            {
                c_notify(new m_notify() { xid = xid, userid = "u_any" });
                c_notify(new m_notify() { xid = xid, userid = "x_any" });
            }
        }
    }
}