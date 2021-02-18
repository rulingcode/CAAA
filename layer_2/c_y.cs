using layer_1;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    class c_y
    {
        internal async Task<output> run<output>(string userid, y y)
        {
            m_packet_y packet_y = new m_packet_y()
            {
                userid = userid,
                yid = y.z_yid,
                data = JsonConvert.SerializeObject(y)
            };
            var data = p_crypto.convert(packet_y);
            m_key key = await a.o2.c_get_key();
            if (key != null)
                data = p_crypto.Encrypt(data, key);
            m_packet packet = new m_packet()
            {
                deviceid = key?.id,
                xid = y.z_xid,
                data = data
            };
            data = p_crypto.convert(packet);
            c_m_x endpoint = await a.x_c.get(y.z_xid);
            data = await a.o1.run_c(endpoint, data);
            if (key != null)
                data = p_crypto.Decrypt(data, key);
            return p_crypto.convert<output>(data);
        }
    }
}