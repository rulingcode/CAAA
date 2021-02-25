using layer_0.cell;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface o3
    {
        Task c_connect();
        c_report c_report { get; set; }
        c_run c_run(string userid = null);
        void s_add_x(m_xip rsv);
        void s_add_y<T>() where T : y, new();
        s_db<T> s_db_share<T>() where T : m_id;
    }
}