using layer_0;
using layer_1;
using layer_2;
using System;
using System.Threading.Tasks;

namespace layer_3
{
    public class o3
    {
        #region constructor
        o3()
        {
            a.o3 = this;
            a.o2 = o2.create();
            a.o2.c_get_key = a.c_key.get;
            a.o2.s_get_key = a.s_key.get;
        }
        public static o3 create() => a.o3 == null ? new o3() : null;
        #endregion

        #region old
        public c_report c_report { get => a.o2.c_report; set => a.o2.c_report = value; }
        public m_x c_m_x { get => a.o2.c_m_x; set => a.o2.c_m_x = value; }
        public c_run c_run(string userid = null) => a.o2.run(userid);
        public void s_add_x(m_x rsv) => a.o2.s_add_x(rsv);
        public void s_add_y<T>() where T : y, new() => a.o2.add_y<T>();
        #endregion

        #region new
        public Task<e_error> c_add_user(string userid, string password) => a.c_user.add(userid, password);
        public Task c_remove_user(string userid) => a.c_user.remove(userid);
        public s_db s_db => a.s_db;
        #endregion
    }
}
