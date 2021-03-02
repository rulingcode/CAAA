using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_1
{
    public class api1_factory
    {
        public static api1 create() => a.api1 == null ? new _api1_() : null;
    }
}
