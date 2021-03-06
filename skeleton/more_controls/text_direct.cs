using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton.more_controls
{
    class text_direct
    {
        private const string fa = "پچجحخهعغفقثصضگکمنتالبیسشوئدذرزطظژ";
        private const string free = "0123456789 .-_";
        public static FlowDirection get_direction(string val)
        {
            foreach (var i in val)
            {
                if (free.Contains(i))
                    continue;
                if (fa.Contains(i))
                    return FlowDirection.RightToLeft;
                return FlowDirection.LeftToRight;
            }
            return FlowDirection.LeftToRight;
        }
    }
}
