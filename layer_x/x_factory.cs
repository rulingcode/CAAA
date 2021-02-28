using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace layer_x
{
    public static class x_factory
    {
        public static x_core create(string xid, Window window)
        {
            if (a.core != null)
                throw new Exception("lkfkbkgjbfjvjfc");
            window.Title = xid;
            a.xid = xid;
            a.core = new x_core();
            config config = new config();
            window.Content = config;
            window.SizeToContent = SizeToContent.WidthAndHeight;
            return a.core;
        }
    }
}