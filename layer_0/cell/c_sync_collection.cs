using layer_0.cell;
using System;
using System.Collections.ObjectModel;
using System.Linq.Expressions;

namespace layer_0.cell
{
    public interface c_sync_collection<T> where T : m_sync
    {
        Expression<Func<T, bool>> filter { get; set; }
        ObservableCollection<T> list { get; }
    }
}