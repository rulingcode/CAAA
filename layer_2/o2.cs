using layer_1;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o2
    {
        public h_report report { get => a.o1.report; set => a.o1.report = value; }
        public m_x2 x_s { get; set; }
        public h_load load_h { get; set; }
        public h_save save_h { get; set; }
        public c_connect connect_c { get; set; }
        public s_connect connect_s { get; set; }
        public Task<e_error> login_c(string userid, string password) => c_login.add(userid, password);
        public void logout_c(string userid) => c_login.remove(userid);
        public s_logout logout_s { get; set; }
        public c_run run_c(string userid = null) => new z_run(userid);
        public void add_y<T>() where T : y, new() => a.x_s.add_y<T>();
        public void add_x(m_x2 rsv) => a.x_s.add_x(rsv);
        public byte[] keys_c { get; set; }
        public byte[] keys_s { get; set; }
        public static string x_center => a.o2.x_s.xid;

        o2() => a.o2 = this;
        public static o2 create() => a.o2 == null ? new o2() : null;
    }
}