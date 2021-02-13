using layer_1;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace layer_2
{
    public abstract class y
    {
        [JsonIgnore] public abstract string z_xid { get; }
        [JsonIgnore] public abstract string z_yid { get; }
        [JsonIgnore] public virtual e_permission z_permission => e_permission.u;
        [JsonIgnore] public string z_deviceid { get; internal set; }
        [JsonIgnore] public string z_userid { get; internal set; }
        internal abstract void run_s(h_reply1 reply);
    }
    public abstract class y<output> : y where output : y_output, new()
    {
        public virtual Task<output> run_c(c_run rsv) => rsv.get<output>(this);
        internal sealed override async void run_s(h_reply1 reply)
        {
            Action action = () =>
            {
                implement((obj) =>
                {
                    if (obj == null)
                        obj = new output();
                    var data = z_crypto.convert(obj);
                    reply(data);
                });
            };
            await Task.Run(action);
        }
        protected virtual void implement(s_reply2<output> reply)
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
    }
    public class y_output
    {
        public e_error z_error { get; set; }
    }
}