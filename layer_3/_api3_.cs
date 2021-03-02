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
    class _api3_ : api3
    {
        internal _api3_(string name)
        {
            a.name = name;
            a.o3 = this;
            a.o2 = api2_factory.create();

            a.c_db = new c.db_factory(name);
            c_db = a.c_db.api<m_data>();
            a.c_recive_notify = new c.receive_notify();
            a.c_middle = new c.middle();

            a.s_key = new key();
            a.s_middle = new middle();
            a.s_db = new MongoClient();

            a.o2.s_get_key = a.s_key.get;
            a.o2.s_before = a.s_middle.run;
            a.o2.c_after = a.c_middle.after;
            a.o2.c_notify = a.c_recive_notify.run;
            a.o2.c_xip = new m_xip() { data = p_res.get_endpoint(10000).ToString() };
        }
        public m_key c_key { get => a.o2.c_key; set => a.o2.c_key = value; }
        public c_report c_report { get => a.o2.c_report; set => a.o2.c_report = value; }
        public c_run c_run(string userid = null) => a.o2.c_run(userid);
        public c_db<m_data> c_db { get; }
        public m_xip s_xip { get => a.o2.s_xip; set => a.o2.s_xip = value; }
        public void s_add_y<T>() where T : y, new() => a.o2.s_add_y<T>();
        public s_db_factory s_db_factory(string xid) => new s.db_factory(xid);
        public s_get_key z_get_key { get; set; }
        public y_before z_middle_y { get; set; }
    }
}
