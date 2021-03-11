using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using layer_0.cell;
using layer_0.x_center;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Threading;

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

        internal void run(m_notify rsv)
        {
            if (a.api2.s_xid != null)
                x_sync(rsv);
            else
                c_sync(rsv);
        }

        private void c_sync(m_notify rsv)
        {
            ThreadPool.QueueUserWorkItem((obj) =>
            {
                var type = list.FirstOrDefault(i => i.xid == rsv.xid);
                if (type == null)
                    return;
                var db = a.c_db.general<m.c_history>();
                string id = rsv.xid + "_" + rsv.userid;
                var time = (db.get(id)?.time) ?? default;
                y_sync y = new() { a_time = time, a_xid = rsv.xid };
                var o = y.run(a.api3.c_run(rsv.userid)).Result;
                if (o.deleted != null && o.deleted.Length != 0)
                {
                    db.coll.DeleteMany(i => o.deleted.Contains(i.id));
                }
                if (o.updated != null && o.updated.Length != 0)
                {
                    var items = o.updated.Select(i => JsonConvert.DeserializeObject(i, type.type)).ToArray();
                    var db2 = a.c_db.a_sync<m_sync>(rsv.xid, rsv.userid);
                    foreach (m_sync item in items)
                        db2.upsert(item);
                }
                if (o.time != time)
                    db.upsert(new m.c_history() { id = id, time = o.time });
            });
        }

        async void x_sync(m_notify rsv)
        {
            if (a.api2.s_xid == all_command.x_center || a.api2.s_xid == null)
            {

            }

            var db = a.s_db;
            var time_binary = (await db.a_x<m_string>().get("last_sync"))?.data;
            var time = time_binary == null ? default : DateTime.FromBinary(long.Parse(time_binary));
            y_sync y = new() { a_time = time, a_xid = all_command.x_center };
            var o = await y.run(a.run_x);

            if (o.deleted != null && o.deleted.Length != 0)
                await db.a_x<m_sync>().delete_many(o.deleted);

            if (o.updated != null && o.updated.Length != 0)
            {
                var items = o.updated.Select(i => JsonConvert.DeserializeObject<sync_center>(i)).ToArray();
                var db2 = db.a_x<sync_center>();
                foreach (var item in items)
                    await db2.upsert(item);
            }
            if (o.time != time)
                await db.a_x<m_string>().upsert(new m_string() { id = "last_sync", data = o.time.ToBinary().ToString() });
        }
    }
}