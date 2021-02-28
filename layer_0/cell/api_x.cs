using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.cell
{
    public interface api_x
    {
        public void add_y<T>() where T : y, new();
        public Task<e_error> connect(m_xip xip, string password, string deviceid = null);
        public s_db_factory db_factory { get; }
    }
}