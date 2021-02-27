﻿namespace layer_0.cell
{
    public interface api2
    {
        m_key c_key { get; set; }
        c_notify c_notify { get; set; }
        c_report c_report { get; set; }
        m_xip c_xip { get; set; }
        c_run c_run(string userid = null);
        y_before c_before { get; set; }
        y_after c_after { get; set; }
        s_get_key s_get_key { get; set; }
        y_before s_before { get; set; }
        y_after s_after { get; set; }
        void s_add_y<T>() where T : y, new();
        void s_add_x(m_xip rsv);
        void s_notify(string xid, string deviceid, string userid);
    }
}