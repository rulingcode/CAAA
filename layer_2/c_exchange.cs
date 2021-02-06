using layer_1;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace layer_2
{
    class c_exchange
    {
        internal static async Task<output> run<output>(string userid, y y)
        {
            m_packet packet = new m_packet()
            {
                userid = userid,
                xid = y.z_xid,
                yid = y.z_xid,
                data = JsonConvert.SerializeObject(y)
            };
            p dv = new p()
            {
                a = c_keys.connect_m.deviceid,
                b = JsonConvert.SerializeObject(packet)
            };
            var data = z_crypto.convert(dv);
            var keys = await c_keys.get(y.z_xid);
            if (keys != null)
                data = z_crypto.Encrypt(data, keys);
            m_endpoint1 endpoint = await c_endpoint.get(y.z_xid);
            data = await a.o1.exchange_c(endpoint, data);
            if (keys != null)
                data = z_crypto.Decrypt(data, keys);
            return z_crypto.convert<output>(data);
        }
    }
}