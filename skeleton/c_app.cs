using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace skeleton
{
    class c_app
    {
        List<z_page> list = new List<z_page>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        Task<z_app> get(string appid)
        {
            return default;
        }
        public async Task<string[]> get_pages(string appid)
        {
            var dv = await get(appid);
            return dv.pages_name;
        }
        public async Task show(string userid, string appid, string page_name)
        {
            await locker.WaitAsync();
            var page = list.FirstOrDefault(i => i.a_userid == userid && i.appid == appid && i.z_name == page_name);
            locker.Release();
            if (page == null)
            {
                var app = await get(appid);
                if (app == null)
                    throw new Exception("kbkhgjjkrjvjgjbfjbfmdnb");
                var type = app.get_type(page_name);
                if (type == null)
                    throw new Exception("kgkbhjbhfjbjgjbjfjfjbjg");
                page = Activator.CreateInstance(type) as z_page;
                page.a_userid = userid;
                page.z_name = page_name;
                page.appid = appid;
                await locker.WaitAsync();
                list.Add(page);
                locker.Release();
                a.main_panel.show(page);
            }
            
        }
    }
}