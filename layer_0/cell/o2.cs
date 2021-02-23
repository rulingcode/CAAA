namespace layer_0.cell
{
    public interface o2
    {
        c_get_key c_get_key { get; set; }
        c_notify c_notify { get; set; }
        c_report c_report { get; set; }
        m_xip c_xip { get; set; }
        c_run run(string userid = null);
        s_get_key s_get_key { get; set; }
        s_middle_y s_middle_y { get; set; }
        void s_add_y<T>() where T : y, new();
        void s_add_x(m_xip rsv);
        void s_notify(string xid, string deviceid, string userid);
    }
}