﻿using layer_0;
using layer_1;
using layer_2;
using System;
using System.Threading.Tasks;
using layer_0.all;

namespace layer_3
{
    class o : o3
    {
        internal o()
        {
            a.o3 = this;
            a.o2 = layer_2.o2_factory.create();
            a.o2.c_get_key = a.c_key.get;
            a.o2.s_get_key = a.s_key.get;
            a.o2.s_middle_y = a.s_middle.run;
            a.o2.c_notify = a.c_recive_notify.run;
        }

        #region old
        public c_report c_report { get => a.o2.c_report; set => a.o2.c_report = value; }
        public m_xip c_xip { get => a.o2.c_xip; set => a.o2.c_xip = value; }
        public c_run c_run(string userid = null) => a.o2.run(userid);
        public void s_add_x(m_xip rsv) => a.o2.s_add_x(rsv);
        public void s_add_y<T>() where T : y, new() => a.o2.s_add_y<T>();
        #endregion

        #region new
        public Task<e_error> c_add_user(string phoneid, string password) => a.c_user.add(phoneid, password);
        public Task c_remove_user(string userid) => a.c_user.remove(userid);
        #endregion
    }
}
