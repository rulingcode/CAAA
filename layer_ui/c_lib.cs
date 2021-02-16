using layer_3.home_unit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace layer_3
{
    internal class c_lib
    {
        List<s_lib> list = new List<s_lib>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        page_loading loading = new page_loading();
        public c_lib()
        {
            list.Add(new lib());
        }
        async Task<s_lib> get(string appid)
        {
            await locker.WaitAsync();
            var lib = list.FirstOrDefault(i => i.id == appid);
            if (lib == null)
            {

            }
            if (lib == null)
                throw new Exception("kdkkvjfnbhghvhdhvhfhvbjhc");
            locker.Release();
            return lib;
        }
        internal async Task<g_page> get(string appid, string pageid, string userid)
        {
            if (pageid == s_lib.loading)
                return loading;
            var lib = await get(appid);
            var dv = lib.pages.FirstOrDefault(i => i.id == pageid);
            if (dv == null)
                throw new Exception("ckvkjbjchvnfjbjckdkv");
            var page = Activator.CreateInstance(dv.type) as g_page;
            page.appid = appid;
            page.userid = userid;
            page.run_c = a.o2.run_c(userid);
            return page;
        }
        internal async Task<string[]> get_pages(string appid)
        {
            var lib = await get(appid);
            return lib.pages.Select(i => i.id).ToArray();
        }
    }
}