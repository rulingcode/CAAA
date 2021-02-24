using layer_0;
using layer_1;
using System;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_2
{
    class o : o2
    {
        internal o()
        {
            a.o2 = this;
            a.o1 = o1.create();

            a.c_notify = new c.notify();
            a.c_x = new c.x();
            a.c_y = new c.y();
            
            a.s_y = new s.y();
            a.s_x = new s.x();
        }

        //---------------------------------------------------------

        public c_report c_report { get => a.o1.report; set => a.o1.report = value; }
        public m_xip c_xip { get; set; }
        public c_get_key c_get_key { get; set; }
        public c_run c_run(string userid = null) => new c.run(userid);
        public c_notify c_notify { get; set; }
        public c_middle_y c_middle_y { get; set; }

        //-----------------------------------------------------------

        public s_get_key s_get_key { get; set; }
        public s_middle_y s_middle_y { get; set; }
        public void s_add_y<T>() where T : layer_0.cell.y, new() => a.s_y.add_y<T>();
        public void s_add_x(m_xip rsv) => a.s_x.add_x(rsv);
        public void s_notify(string xid, string deviceid, string userid) => a.s_notify.send(xid, deviceid, userid);
    }
}