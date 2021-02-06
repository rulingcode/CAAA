using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    public delegate Task<bool> s_login(string userid, string deviceid, string password);
}
