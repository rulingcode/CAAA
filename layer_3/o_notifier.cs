using layer_1;
using layer_2;
using System;
using System.Net;
using System.Net.Sockets;

namespace layer_3
{
    public class o_notifier
    {
        o_notifier()
        {
            a.o = this;
        }
        public c_report report_c { get; set; }
        public void add_x(m_x x_m) => a.x_c.add(x_m);
        public c_get_key get_key_c { get; set; }
        public s_get_key get_key_s { get; set; }
        public s_get_all_device get_all_device_s { get; set; }
        public c_get_x get_x_c { get; set; }
        public void send_notify(string xid, string userid, string commnd) => a.sender_s.send_notify(xid, userid, commnd);
        public c_receive_notify receive_notify_c { get; set; }
        public static o_notifier create() => a.o == null ? new o_notifier() : null;
    }
}
