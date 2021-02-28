using layer_0.cell;
using layer_0.x_center;
using layer_3;
using System;
using System.Threading.Tasks;

namespace layer_x
{
    public class x_core
    {
        internal x_core()
        {
            a.core = this;
            a.api3 = api3_factory.create();
            run = a.api3.c_run(a.xid);
            a.db = a.api3.s_db_factory(a.xid);

        }
        public static s_db_factory db => a.db;
        public c_run run { get; private set; }
        public void add_y<T>() where T : y, new() => a.api3.s_add_y<T>();
        internal async Task<e_error> connect(string password)
        {
            await a.api3.c_connect("d_" + a.xid);
            y_xlogin y = new()
            {
                a_xid = a.xid,
                a_password = password
            };
            var dv = await y.run(run);
            return dv.z_error;
        }
    }
}