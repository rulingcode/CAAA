using layer_0;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_2.c
{
    class run : c_run
    {
        readonly string userid;
        internal run(string userid) => this.userid = userid;
        public Task<T> get<T>(layer_0.cell.y y) where T : y_output => a.c_y.run<T>(userid, y);
    }
}