using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface c_db<T>
    {
        ILiteCollection<T> coll { get; }
        void upsert(T val);
        T get(string id);
        T get(Expression<Func<T, bool>> filter);
        bool any(Expression<Func<T, bool>> filter);
    }
}
