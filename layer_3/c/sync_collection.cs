using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace layer_3.c
{
    class sync_collection<T> : c_sync_collection<T> where T : m_sync
    {

        public ObservableCollection<T> list { get; } = new ObservableCollection<T>();
        public Expression<Func<T, bool>> filter { get; set; }
    }
}
