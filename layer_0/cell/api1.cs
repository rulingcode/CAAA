using layer_0.cell;
using System.Threading.Tasks;

namespace layer_1
{
    public interface api1
    {
        c_report c_report { get; set; }
        s_exchange s_exchange { get; set; }
        Task<byte[]> c_exchange(m_xip xip, byte[] data);
        public m_xip s_xip { get; set; }
    }
}