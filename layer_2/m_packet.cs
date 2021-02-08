using System;
using System.Collections.Generic;
using System.Text;

namespace layer_2
{
    class m_packet
    {
        public string deviceid { get; set; }
        public string xid { get; set; }
        public byte[] data { get; set; }
    }
}
