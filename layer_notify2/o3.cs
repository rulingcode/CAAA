using layer_1;
using layer_2;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    public class o3
    {
        #region constructor
        o3()
        {
            a.o3 = this;
            a.o2 = o2.create();
        }
        public static o3 create() => a.o3 == null ? new o3() : null;
        #endregion

        #region overwrite
        public void add_x(m_x x_m)
        {

        }
        public c_get_key get_key_c { get => a.o2.c_get_key; set => a.o2.c_get_key = value; }
        public c_report report_c { get => a.o2.report_c; set => a.o2.report_c = value; }
        #endregion

        #region new features
        public void send_notify_s(string xid, string userid, string command) => a.s_sender.send_notify(xid, userid, command);
        public c_receive_notify recive_notify_c { get; set; }
        public s_get_all_device s_get_all_device { get; set; }
        #endregion
    }
}
