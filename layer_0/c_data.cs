using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0
{
    class c_data
    {
        public string xid { get; set; }
        public c_command command { get; set; }
        public string data { get; set; }
        public byte[] encrypt_data { get; set; }
    }
}
