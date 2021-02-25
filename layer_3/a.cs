﻿using layer_0;
using layer_1;
using layer_2;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_3
{
    class a
    {
        internal static _o3_ o3;
        internal static o2 o2;
        internal static c.key c_key;
        internal static c.db c_db;
        internal static c.receive_notify c_recive_notify;
        internal static s.key s_key;
        internal static s.middle s_middle;
        internal static MongoClient s_db_engin;
        internal static c.middle c_middle;

        internal static c_run run(string xid = null) => o3.c_run(xid);
        internal static s_db<T> share_db<T>() where T : m_id => new s.db<T>(s_db_engin.GetDatabase("share").GetCollection<T>(typeof(T).Name));

    }
}
