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
            m_packet_y packet_y = new m_packet_y()
            {
                userid = userid,
                yid = y.z_yid,
                data = JsonConvert.SerializeObject(y)
            };
            var data = p_crypto.convert(packet_y);
            m_key key = a.o2.c_key;
            if (key != null)
                data = p_crypto.Encrypt(data, key);
            m_packet packet = new m_packet()
            {
                deviceid = key?.id,
                xid = y.z_xid,
                data = data
            };
            data = p_crypto.convert(packet);
            m_xip endpoint = await a.c_x.get(y.z_xid);
            data = await a.o1.run_c(endpoint, data);
            if (key != null)
                data = p_crypto.Decrypt(data, key);
            var o = p_crypto.convert<output>(data);
            await a.o2.c_after(y, o);
            return o;
        }
    }
}