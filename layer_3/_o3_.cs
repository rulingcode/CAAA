using layer_0;
using layer_1;
using layer_2;
using System;
using System.Threading.Tasks;
using layer_0.cell;
using MongoDB.Driver;
using layer_3.s;

namespace layer_3
{
    class _o3_ : o3
    {
        internal _o3_()
        {
            a.o3 = this;
            a.o2 = o2_factory.create();

            a.c_db = new c.db();
            a.c_key = new c.key();
            a.c_recive_notify = new c.receive_notify();
            a.c_middle = new c.middle();

            a.s_key = new key();
            a.s_middle = new middle();
            a.s_db_engin = new MongoClient();

            a.o2.s_get_key = a.s_key.get;
            a.o2.s_middle_y = a.s_middle.run;
            a.o2.c_middle_y = a.c_middle.run;
            a.o2.c_notify = a.c_recive_notify.run;
            a.o2.c_xip = new m_xip() { data = p_res.get_endpoint(10000).ToString() };
        }
        public c_report c_report { get => a.o2.c_report; set => a.o2.c_report = value; }
        public Task c_connect() => a.c_key.connect();
        public c_run c_run(string userid = null) => a.o2.c_run(userid);
        public void s_add_x(m_xip rsv) => a.o2.s_add_x(rsv);
        public void s_add_y<T>() where T : y, new() => a.o2.s_add_y<T>();
        public s_db<T> s_db_share<T>() where T : m_id => a.share_db<T>();
    }
}
