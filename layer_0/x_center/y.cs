﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_0.x_center
{
    public abstract class y<output> : cell.y<output> where output : y_output, new()
    {
        public sealed override string z_xid => "x_center";
    }
}
