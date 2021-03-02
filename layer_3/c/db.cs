using layer_0.cell;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    class db<T> : c_db<T> where T : m_id
    {
        public ILiteCollection<T> coll { get; }
        internal db(ILiteCollection<T> lite) => coll = lite;
        public bool any(Expression<Func<T, bool>> filter) => coll.Find(filter).Any();
        public T get(string id) => coll.FindOne(i => i.id == id);
        public T get(Expression<Func<T, bool>> filter) => coll.FindOne(filter);
        public void upsert(T val) => coll.Upsert(val);
    }
}
