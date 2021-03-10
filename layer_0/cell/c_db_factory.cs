using layer_0.cell;

namespace layer_0.cell
{
    public interface c_db_factory
    {
        c_db<T> general<T>() where T : m_id;
        c_db<T> a_sync<T>(string xid, string userid) where T : m_sync;
    }
}