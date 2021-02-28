using layer_0.cell;
using System.Threading.Tasks;

namespace layer_1
{
    public interface Io1
    {
        c_report report { get; set; }
        s_y y_s { get; set; }
        m_xip s_xip { get; set; }
        Task<byte[]> run_c(m_xip val, byte[] data);
    }
}