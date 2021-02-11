using layer_1;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o2
    {
        internal static string x_center => a.o2.x_m.id;
        public h_report report_h { get => a.o1.report; set => a.o1.report = value; }
        public m_x x_m { get; set; }
        public string skeletid { get; set; }
        public string deviceid { get; internal set; }
        public h_load load { get; set; }
        public h_save save { get; set; }
        public h_get_password get_password { get; set; }
        public h_check_password check_password { get; set; }
        public void logout_c(string userid) => c_login.remove(userid);
        public s_logout logout_s { get; set; }
        public c_run run(string userid = null) => new z_run(userid);
        public void add_y<T>() where T : y, new() => a.x_s.add_y<T>();
        public void add_x(m_x rsv) => a.x_s.add_x(rsv);
        public byte[] key_c { get; set; }
        public byte[] key_s { get; set; }
        public void start()
        {
            a.key_c.start();
        }
        o2()
        {
            a.o2 = this;
            a.o1 = o1.create();
            a.keys_s = new s_key();
            a.key_c = new c_key();
            a.x_s = new s_x();
        }
        public static o2 create() => a.o2 == null ? new o2() : null;
    }
}