using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    public delegate Task<bool> s_connect(string skeletid, string c_endpoint, string password);
}
