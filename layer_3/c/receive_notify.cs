using layer_0;
using System;
using System.Collections.Generic;
using System.Linq;
using layer_0.cell;

namespace layer_3.c
{
    internal class receive_notify
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
        public receive_notify()
        {
            var type = typeof(m_sync);
            var dv = type.Assembly.GetTypes().Where(i => i.IsSubclassOf(type)).Select(i => new item(i)).ToArray();
            list.AddRange(dv);
        }
        internal void run(m_notify rsv)
        {
           
        }
    }
}