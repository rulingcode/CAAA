using layer_0.cell;
using layer_0.x_center;
using layer_3;
using System;
using System.Threading.Tasks;

namespace layer_x
{
    public class x
    {
        internal x()
        {
            a.core = this;
            a.api3 = api3_factory.create("db_" + a.xid);
            run = a.api3.c_run(a.xid);
            a.db = a.api3.s_db_factory(a.xid);
        }
        public static s_db_factory db => a.db;
        public static c_run run { get; private set; }
        public static void add_y<T>() where T : y, new() => a.api3.s_add_y<T>();
    }
}