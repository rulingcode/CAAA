using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    public class sync_collection_factory : c_sync_collection_factory
    {
        public c_sync_collection<T> get<T>() where T : m_sync
        {
            throw new NotImplementedException();
        }
    }
}
