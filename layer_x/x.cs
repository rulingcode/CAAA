using layer_0.cell;
using layer_0.x_center;
using layer_3;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace layer_x
{
    public class x
    {
        internal x()
        {
            a.x = this;
            a.api3 = api3_factory.create("db_" + a.xid);
            run = a.api3.c_run(a.xid);
            a.db = a.api3.s_db_factory(a.xid);
            a.key = new key();
        }
        public static s_db_factory db => a.db;
        public static c_run run { get; private set; }
        public static void add_y<T>() where T : y, new() => a.api3.s_add_y<T>();
        public static x z_create(string xid, Window window)
        {
            if (a.x != null)
                throw new Exception("lkfkbkgjbfjvjfc");
            window.Title = xid;
            a.x = new x();
            a.xid = xid;
            a.body = new body();
            window.Content = a.body;
            a.body.connection.start();
            window.SizeToContent = SizeToContent.WidthAndHeight;
            return a.x;
        }
    }
}