using layer_0;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using layer_0.cell;

namespace layer_3.s
{
    class db_factory : s_db_factory
    {
        private readonly string xid;
        internal db_factory(string xid) => this.xid = xid;
        public s_db<T> a_x<T>() where T : m_id
        {
            return new db<T>(a.client.GetDatabase(xid).GetCollection<T>("x_" + typeof(T).Name));
        }
        public s_db<T> a_user<T>(string userid) where T : m_id
        {
            return new db<T>(a.client.GetDatabase(xid).GetCollection<T>("u_" + userid + "_" + typeof(T).Name));
        }
    }
}