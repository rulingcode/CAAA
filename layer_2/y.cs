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
        [JsonIgnore] public virtual e_permission z_permission => e_permission.user;
        [JsonIgnore] public string z_userid { get; set; }
        internal abstract void implement_(h_reply1 reply);
    }
    public abstract class y<output> : y where output : y_output
    {
        public virtual Task<output> run(c_run rsv) => rsv.get<output>(this);
        internal sealed override void implement_(h_reply1 reply)
        {
            Action action = () =>
            {
                implement((obj) =>
                {
                    var data = obj == null ? null : z_crypto.convert(obj);
                    reply(data);
                });
            };
            Task.Run(action);
        }
        protected virtual void implement(h_reply2<output> reply)
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
    }
    public class y_output
    {
        public e_error z_error { get; set; }
    }
}