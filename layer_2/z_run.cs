﻿using layer_0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    class z_run : c_run
    {
        readonly string userid;
        internal z_run(string userid) => this.userid = userid;
        public Task<T> get<T>(y y) where T : y_output => a.y_c.run<T>(userid, y);
    }
}