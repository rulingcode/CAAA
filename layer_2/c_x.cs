using layer_1;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    class c_x
    {
        internal static async Task<output> run<output>(string userid, y y)
        {
            m_packet_y packet_y = new m_packet_y()
            {
                userid = userid,
                yid = y.z_xid,
                data = JsonConvert.SerializeObject(y)
            };
            var data = z_crypto.convert(packet_y);
            var key = await a.key_c.get(y.z_xid);
            if (key != null)
                data = z_crypto.Encrypt(data, key);
            m_packet packet = new m_packet()
            {
                deviceid = a.deviceid,
                xid = y.z_xid,
                data = data
            };
            data = z_crypto.convert(packet);
            m_x1 endpoint = await c_endpoint.get(y.z_xid);
            data = await a.o1.exchange_c(endpoint, data);
            if (key != null)
                data = z_crypto.Decrypt(data, key);
            return z_crypto.convert<output>(data);
        }
    }
}