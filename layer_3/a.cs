using layer_0;
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
        internal static o o3;
        internal static layer_0.cell.o2 o2;
        internal static c_key c_key;
        internal static s_key s_key;
        internal static c_user c_user;
        internal static s_db_ s_db;
        internal static c_db c_db;
        internal static s_middle s_middle;
        internal static MongoClient client = new MongoClient();
        internal static c_receive_notify c_recive_notify;
        internal const string x_center = nameof(x_center);
        internal static c_run run(string xid = null) => o3.c_run(xid);
    }
}
