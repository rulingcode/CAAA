using LiteDB;
using Newtonsoft.Json;

namespace layer_0.cell
{
    public abstract class m_sync : m_id
    {
        [BsonIgnore] [JsonIgnore] public abstract string z_xid { get; }
        [BsonIgnore] [JsonIgnore] public abstract e_permission permission { get; }
    }
}
