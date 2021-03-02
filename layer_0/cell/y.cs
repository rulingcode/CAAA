using System;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace layer_0.cell
{
    public abstract class y
    {
        [JsonIgnore] public abstract string z_xid { get; }
        [JsonIgnore] public abstract string z_yid { get; }
        [JsonIgnore] public virtual e_permission z_permission => e_permission.u;
        [JsonIgnore] public string z_deviceid { get; set; }
        [JsonIgnore] public string z_userid { get; set; }
        [JsonIgnore] public s_db_factory z_db { get; set; }
        public abstract void z_run(s_reply_data reply);
    }
    public abstract class y<output> : y where output : o_base, new()
    {
        public virtual Task<output> run(c_run rsv) => rsv.get<output>(this);
        public sealed override async void z_run(s_reply_data reply)
        {
            Action action = () =>
            {
                implement((obj) =>
                {
                    if (obj == null)
                        obj = new output();
                    var data = p_crypto.convert(obj);
                    reply(data);
                });
            };
            await Task.Run(action);
        }
        protected virtual void implement(s_reply_o<output> reply)
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
    }
    public class o_base
    {
        public e_error z_error { get; set; }
    }
    public class o_base<error> : o_base where error : Enum
    {
        public error a_error { get; set; }
    }
}