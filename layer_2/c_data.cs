using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    class c_data
    {
        public c_command command { get; set; }
        public string message_id { get; set; }
        public string xid { get; set; }
        public string deviceid { get; set; }
        public byte[] data { get; set; }
    }
}
