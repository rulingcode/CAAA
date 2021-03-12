namespace layer_0.cell
{
    public interface s_db_factory
    {
        s_db<T> general_x<T>() where T : m_id, new();
        s_db<T> user<T>(string userid) where T : m_id, new();
    }
}