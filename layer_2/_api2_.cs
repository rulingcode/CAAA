﻿using layer_0;
using layer_1;
using System;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_2
{
    class _api2_ : api2
    {
        internal _api2_()
        {
            a.o2 = this;
            a.api1 = api1_factory.create();

            a.c_notify = new c.notify();
            a.c_x = new c.x();
            a.c_y = new c.y();

            a.s_y = new s.y();
        }

        //---------------------------------------------------------

        public c_report c_report { get => a.api1.c_report; set => a.api1.c_report = value; }
        public m_xip c_xip { get; set; }
        public m_key c_key { get; set; }
        public c_run c_run(string userid = null) => new c.run(userid);
        public c_notify c_notify { get; set; }
        public y_before c_before { get; set; }
        public y_after c_after { get; set; }

        //-----------------------------------------------------------

        public s_get_key s_get_key { get; set; }
        public y_before s_before { get; set; }
        public y_after s_after { get; set; }

        public void s_add_y<T>() where T : layer_0.cell.y, new() => a.s_y.add_y<T>();
        public m_xip s_xip
        {
            get => a.api1.s_xip;
            set
            {
                if (value != null && value.port % 2 != 0)
                    throw new Exception("kvkjnjjjfjcdjbgjbfnd");
                a.api1.s_xip = value;
            }
        }
        public void s_notify(string xid, string deviceid, string userid) => a.s_notify.send(xid, deviceid, userid);
    }
}