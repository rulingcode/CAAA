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
        [JsonIgnore] public c_run z_run { get; set; }
        public abstract void zz_reply(s_reply_data reply);
    }
    public abstract class y<o> : y where o : o_base, new()
    {
        public virtual Task<o> run(c_run val) => val.get<o>(this);
        s_reply_data reply_data;
        public sealed override async void zz_reply(s_reply_data reply_data)
        {
            this.reply_data = reply_data;
            await Task.Run(implement);
        }
        protected void reply(o val = null)
        {
            if (val == null)
                val = new o();
            var data = p_crypto.convert(val);
            reply_data(data, val.z_error);
        }
        protected virtual void implement()
        {
            throw new Exception("ldkvjgjbjfhcbfjvjfb");
        }
        protected async Task<e_license> z_license()
        {
            var db = z_db.a_x<m_position>();
            var dv = await db.get(z_userid);
            return dv?.e ?? e_license.normal;
        }
        protected async void z_license(e_license license)
        {
            var db = z_db.a_x<m_position>();
            if (license == e_license.normal)
                await db.delete(z_userid);
            else
                await db.upsert(new m_position() { id = z_userid, e = license });
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