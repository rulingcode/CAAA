namespace layer_0.cell
{
    public interface c_sync_collection_factory
    {
        c_sync_collection<T> get<T>() where T : m_sync;
    }
}