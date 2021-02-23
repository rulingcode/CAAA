using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_4
{
    class c_app
    {
        public async Task<string[]> get(string userid)
        {
            return await Task.FromResult(new string[] { "home" });
        }
        public void set(string userid, string[] apps)
        {

        }
    }
}
