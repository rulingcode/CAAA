using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using layer_0.cell;
using layer_0.x_center;

namespace layer_3.c
{
    internal class notify
    {
        List<item> list = new List<item>();
        class item
        {
            public string xid { get; }
            public Type type { get; }
            public item(Type type)
            {
                xid = type.FullName.Split('.')[1];
                this.type = type;
            }
        }
        public notify()
        {
            var type = typeof(m_sync);
            var dv = type.Assembly.GetTypes().Where(i => i.IsSubclassOf(type)).Select(i => new item(i)).ToArray();
            list.AddRange(dv);
        }
        internal async void run(m_notify rsv)
        {
            if (rsv.xid == "x_center" && a.run_x != null)
            {
                if (rsv.userid != "x_any") throw new Exception("kbkgjnjjbjfjvjfhvj");

                var data = a.api3.c_db.get("time")?.data;
                DateTime time = default;
                if (data != null)
                    time = p_crypto.convert<DateTime>(data);
                y_sync y = new() { a_time = time, a_xid = "x_center" };
                var dv = await y.run(a.run_x);
            }
            else
            {

            }
        }
    }
}