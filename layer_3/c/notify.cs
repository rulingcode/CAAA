using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using layer_0.cell;
using layer_0.x_center;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace layer_3.c
{
    internal class notify
    {
        List<item> list = new List<item>();
        class item
        {
            public string xid { get; }
            public Type type { get; }
            public e_permission permission { get; }
            public item(Type type)
            {
                this.type = type;
                var dv = Activator.CreateInstance(type) as m_sync;
                xid = dv.z_xid;
                permission = dv.z_permission;
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
            var type = list.FirstOrDefault(i => i.xid == rsv.xid);
            bool x_ok() => rsv.xid == a.api3.s_xid || rsv.userid == "x_any";
            bool no_x() => a.api3.s_xid == null || !x_ok();
            bool paradox() => type.permission == e_permission.x && no_x();
            if (type == null || paradox())
                return;
            if (rsv.userid == "x_any")
                rsv.userid = a.api3.s_xid;
            var db = a.c_db.api<m.c_history>();
            string id = rsv.xid + "_" + rsv.userid;
            var time = (db.get(id)?.time) ?? default;
            y_sync y = new() { a_time = time, a_xid = rsv.xid };
            var o = await y.run(a.api3.c_run(rsv.userid));

            if (o.deleted != null && o.deleted.Length != 0)
            {
                db.coll.DeleteMany(i => o.deleted.Contains(i.id));
            }
            if (o.updated != null && o.updated.Length != 0)
            {
                var items = o.updated.Select(i => JsonConvert.DeserializeObject(i, type.type)).ToArray();
                var db2 = a.c_db.a_user<m_sync>(rsv.xid, rsv.userid);
                foreach (m_sync item in items)
                    db2.upsert(item);
            }
            if (o.time != time)
                db.upsert(new m.c_history() { id = id, time = o.time });
        }
    }
}