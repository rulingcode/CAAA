using LiteDB;

namespace layer_0.cell
{
    public abstract class m_sync : m_id
    {
        [BsonIgnore] public abstract string z_xid { get; }
    }
}
