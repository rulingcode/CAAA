using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3
{
    public class api3_factory
    {
        public static api3 create<T>(string xid) where T : m_sync, new()
        {
            if (a.api3 != null)
                return null;
            new _api3_(xid);
            a.api3.s_add_y<sync<T>>();
            return a.api3;
        }
        public static api3 create(string cid)
        {
            if (a.api3 != null)
                return null;
            new _api3_(cid);
            return a.api3;
        }
    }
}
