using layer_1;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o2
    {
        internal static string x_center => a.o2.x_m.id;
        public h_report report { get => a.o1.report; set => a.o1.report = value; }
        public m_x x_m { get; set; }
        public c_get_key c_get_key { get; set; }
        public s_get_key s_get_key { get; set; }
        public s_check_userid check_userid_s { get; set; }
        public c_run run(string userid = null) => new z_run(userid);
        
        public void add_y<T>() where T : y, new() => a.y_s.add_y<T>();
        public void add_x(m_x rsv) => a.x_s.add_x(rsv);
        o2()
        {
            a.o2 = this;
            a.o1 = o1.create();
            a.y_s = new s_y();
            a.x_s = new s_x();
        }
        public static o2 create() => a.o2 == null ? new o2() : null;
    }
}