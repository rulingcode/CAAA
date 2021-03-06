using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public abstract class z
    {
        internal abstract UIElement ui { get; }
        internal abstract Task<object> get();
        protected abstract void focus();
        internal void focus_() => focus();
    }
    public abstract class z<T> : z
    {
        public Task<T> run(g_page page) => page.run<T>(this);
        TaskCompletionSource<T> source;
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        internal async override Task<object> get()
        {
            await locker.WaitAsync();
            implement();
            focus();
            source = new TaskCompletionSource<T>();
            var dv = await source.Task;
            locker.Release();
            return dv;
        }
        protected void reply(T rsv) => source.SetResult(rsv);
        protected abstract void implement();
    }
}
