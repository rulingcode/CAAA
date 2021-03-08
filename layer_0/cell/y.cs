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
    public abstract class y<o> : y where o : o_base, new()
    {
        public virtual Task<o> run(c_run rsv) => rsv.get<o>(this);
        s_reply_data reply_data;
        public sealed override async void z_run(s_reply_data reply_data)
        {
            this.reply_data = reply_data;
            await Task.Run(met);
            void met() => implement();
        }
        protected void reply(o val = null)
        {
            if (val == null)
                val = new o();
            var data = p_crypto.convert(val);
            reply_data(data);
        }
        protected virtual void implement()
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
    }
    public abstract class y<o, error> : y<o> where o : o_base<error>, new() where error : Enum
    {
        protected void reply(error e)
        {
            reply(new o() { a_error = e });
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