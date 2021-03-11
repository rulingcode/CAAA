namespace layer_0.cell
{
    public interface s_db_factory
    {
        s_db<T> a_x<T>() where T : m_id, new();
        s_db<T> a_user<T>(string userid) where T : m_id, new();
    }
}