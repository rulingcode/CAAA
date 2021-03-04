using layer_0;
using layer_1;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_2.c
{
    class y
    {
        internal async Task<output> run<output>(string userid, layer_0.cell.y y) where output : o_base
        {
            m_y packet_y = new m_y()
            {
                userid = userid,
                yid = y.z_yid,
                data = JsonConvert.SerializeObject(y)
            };
            var data = p_crypto.convert(packet_y);
            m_key key = a.api2.c_key;
            if (key != null)
                data = p_crypto.Encrypt(data, key);
            m_packet packet = new m_packet()
            {
                deviceid = key?.id,
                data = data
            };
            data = p_crypto.convert(packet);
            m_xip xip = await a.c_x.get(y.z_xid);
            data = await a.api1.c_exchange(xip, data);
            if (key != null)
                data = p_crypto.Decrypt(data, key);
            var o = p_crypto.convert<output>(data);
            await a.api2.c_after(y, o);
            return o;
        }
    }
}