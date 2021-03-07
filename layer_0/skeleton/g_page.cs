using System.Threading.Tasks;
using System.Windows;

namespace skeleton
{
    public interface g_page
    {
        string userid { get; }
        string z_appid { get; }
        string z_name { get; }
        object z_ui { get; }
        Task<string> message(z_message.e_type e, string text, params string[] options);
        Task<T> run<T>(z_dialog z);
    }
}