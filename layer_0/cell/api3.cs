using layer_0.cell;
using System;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface api3
    {
        Task<e_error> c_connect(string skeletid, string password, string xid);
        Task<e_error> c_connect();
        c_report c_report { get; set; }
        c_run c_run(string userid = null);
        m_xip s_xip { get; set; }
        void s_add_y<T>() where T : y, new();
        s_db_factory s_db_factory(string xid);
        s_get_key z_get_key { get; set; }
        y_before z_middle_y { get; set; }
    }
}