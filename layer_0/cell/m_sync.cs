using LiteDB;
using Newtonsoft.Json;

namespace layer_0.cell
{
    public abstract class m_sync : m_id
    {
        [BsonIgnore] [JsonIgnore] public abstract string z_xid { get; }
        [BsonIgnore] [JsonIgnore] public virtual e_permission z_permission { get; } = e_permission.u;
    }
}
