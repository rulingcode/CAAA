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
        public abstract void z_run(s_reply reply);
        public s_db_factory z_db { get; set; }
    }
    public abstract class y<output> : y where output : y_output, new()
    {
        public virtual Task<output> run(c_run rsv) => rsv.get<output>(this);
        public sealed override async void z_run(s_reply reply)
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
        protected virtual void implement(s_reply<output> reply)
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
    }
    public class y_output
    {
        public e_error z_error { get; set; }
    }
    public class y_output<error> : y_output where error : Enum
    {
        public error a_error { get; set; }
    }
}