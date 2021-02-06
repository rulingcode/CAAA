using layer_1;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o2
    {
        public m_endpoint2 center_endpoint { get; set; }
        public Task<e_error> connect_c(m_connect val) => c_keys.connect(val);
        public s_connect connect_s { get; set; }
        public Task<e_error> login_c(string userid, string password) => c_login.add(userid, password);
        public s_login login_s { get; set; }
        public void logout_c(string userid) => c_login.remove(userid);
        public s_logout logout_s { get; set; }
        public c_run run_c(string userid = null) => new z_run(userid);
        public void add_y<y>() => s_exchange.run<y>();
        public void add_x(m_endpoint2 endpoint) => s_endpoint.add_x(endpoint);
        public byte[] keys_c { get; set; }
        public byte[] keys_s { get; set; }
        public static string x_center => a.o2.center_endpoint.xid;
        o2() => a.o2 = this;
        public static o2 create() => a.o2 == null ? new o2() : null;
    }
}