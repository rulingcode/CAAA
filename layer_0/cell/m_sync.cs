using LiteDB;
using Newtonsoft.Json;
using System;

namespace layer_0.cell
{
    public class m_sync : m_id
    {
        [BsonIgnore] [JsonIgnore] public virtual string z_xid => throw new Exception("fkgkjfjjgjvjd");
        [BsonIgnore] [JsonIgnore] public virtual e_permission z_permission { get; } = e_permission.u;
    }
}
