using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.home_unit
{
    class lib : s_lib
    {
        public override string id => "home";
        public lib()
        {
            add_c<page_login>();
        }
    }
}
