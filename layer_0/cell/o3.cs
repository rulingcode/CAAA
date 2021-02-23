using layer_0.cell;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface o3
    {
        c_report c_report { get; set; }
        Task<e_error> c_add_user(string phoneid, string password);
        Task c_remove_user(string userid);
        c_run c_run(string userid = null);
        void s_add_x(m_xip rsv);
        void s_add_y<T>() where T : y, new();
    }
}