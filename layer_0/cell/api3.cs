﻿using layer_0.cell;
using System;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface api3
    {
        m_key c_key { get; set; }
        c_report c_report { get; set; }
        c_run c_run(string userid = null);
        c_db_factory c_db { get; }
        m_xip s_xip { get; set; }
        void s_add_y<T>() where T : y, new();
        s_db_factory s_db { get; }
        s_get_key z_get_key { get; set; }
        void s_notify(string userid);
    }
}