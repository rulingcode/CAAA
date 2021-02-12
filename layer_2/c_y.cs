using layer_1;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    class c_y
    {
        internal static async Task<output> run<output>(string userid, y y)
        {
            m_packet_y packet_y = new m_packet_y()
            {
                userid = userid,
                yid = y.z_yid,
                data = JsonConvert.SerializeObject(y)
            };
            var data = z_crypto.convert(packet_y);
            m_key key = await a.o2.c_get_key();
            if (key != null)
                data = z_crypto.Encrypt(data, key);
            m_packet packet = new m_packet()
            {
                deviceid = key?.id,
                xid = y.z_xid,
                data = data
            };
            data = z_crypto.convert(packet);
            m_x endpoint = await c_x.get(y.z_xid);
            data = await a.o1.exchange_c(endpoint, data);
            if (key != null)
                data = z_crypto.Decrypt(data, key);
            return z_crypto.convert<output>(data);
        }
    }
}