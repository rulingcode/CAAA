using layer_0.cell;

namespace layer_0.cell
{
    public interface c_db_factory
    {
        c_db<T> api<T>();
        c_db<T> a_user<T>(string xid, string userid) where T : m_sync;
    }
}