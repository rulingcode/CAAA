﻿using layer_0;
using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.all;
using layer_0.x_center;

namespace layer_2.s
{
    class get_x : y_get_x
    {
        internal static output o = new output() { list = new m_xip[0] };
        protected override void implement(s_reply<output> reply) => reply(o);
    }
}
