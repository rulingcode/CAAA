namespace skeleton
{
    public interface g_message
    {
        e_type e { get; set; }
        string[] option { get; set; }
        string text { get; set; }
        string title { get; set; }
        public enum e_type
        {
            info,
            warning,
            error
        }
    }
}