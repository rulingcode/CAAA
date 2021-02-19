using layer_0;
using layer_1;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o2
    {
        #region constructor
        o2()
        {
            a.o2 = this;
            a.o1 = o1.create();
            a.y_s = new s_y();
            a.x_s = new s_x();
        }
        public static o2 create() => a.o2 == null ? new o2() : null;
        #endregion

        #region overwrite
        public c_report c_report { get => a.o1.report; set => a.o1.report = value; }
        #endregion

        #region exchange
        public m_xip c_m_x { get; set; }
        public c_get_key c_get_key { get; set; }
        public s_get_key s_get_key { get; set; }
        public s_middle_y s_middle_y { get; set; }
        public c_run run(string userid = null) => new z_run(userid);
        public void add_y<T>() where T : y, new() => a.y_s.add_y<T>();
        public void s_add_x(m_xip rsv) => a.x_s.add_x(rsv);
        public Task<m_xip> c_get_x(string xid) => a.x_c.get(xid);
        
        #endregion

        #region notify
        public void send_notify_s(string xid, string userid, string command) => a.s_sender.send_notify(xid, userid, command);
        public c_receive_notify c_recive_notify { get; set; }
        public s_get_all_device s_get_all_device { get; set; }
        #endregion
    }
}