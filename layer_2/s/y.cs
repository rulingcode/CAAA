using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;

namespace layer_2.s
{
    class y
    {
        List<item> list = new List<item>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        class item
        {
            public string xid { get; set; }
            public string yid { get; set; }
            public Type type { get; set; }
            public override string ToString()
            {
                return xid + "." + yid + " : " + type.FullName;
            }
        }
        public y()
        {
            a.o1.y_s = y_s;
        }
        async void y_s(byte[] data, s_reply reply)
        {
            var packet = p_crypto.convert<m_packet>(data);
            m_key keys = null;
            if (packet.deviceid != null)
            {
                keys = await a.o2.s_get_key(packet.deviceid);
                if (keys == null)
                {
                    met(null, e_error_base.invalid_deviceid);
                    return;
                }
                try
                {
                    packet.data = p_crypto.Decrypt(packet.data, keys);
                }
                catch
                {
                    met(null, e_error_base.invalid_encryption);
                    return;
                }
            }

            var packet_y = p_crypto.convert<m_packet_y>(packet.data);
            var type = await get(packet.xid, packet_y.yid);
            if (type == null)
            {
                met(null, e_error_base.no_implement);
                return;
            }
            var y = JsonConvert.DeserializeObject(packet_y.data, type) as layer_0.cell.y;
            e_permission p = 0;
            if (packet.deviceid == null)
            {
                p = e_permission.non;
                if (packet_y.userid != null)
                {
                    met(null, e_error_base.invalid_userid);
                    return;
                }
            }
            else
            {
                if (packet_y.userid == null)
                    p = e_permission.k;
                else
                    switch (packet_y.userid[0])
                    {
                        case 'u': p = e_permission.u; break;
                        case 'x': p = e_permission.x; break;
                        default:
                            met(null, e_error_base.invalid_userid_prefix);
                            return;
                    }
            }
            if (y.z_permission > p)
            {
                met(null, e_error_base.invalid_permission);
                return;
            }
            y.z_userid = packet_y.userid;
            y.z_deviceid = packet.deviceid;
            var error = await a.o2.s_middle_y(y);
            if (error != e_error_base.non)
            {
                met(null, error);
                return;
            }
            y.z_run(met);
            void met(byte[] data, e_error_base e)
            {
                if (data == null)
                {
                    o_base obj = new o_base() { z_error = e };
                    data = p_crypto.convert(obj);
                }

                if (keys != null)
                    data = p_crypto.Encrypt(data, keys);
                reply(data, e);
            }
        }
        internal async void add_y<T>() where T : layer_0.cell.y, new()
        {
            await locker.WaitAsync();
            T dv = new T();
            if (list.Any(i => i.xid == dv.z_xid && i.yid == dv.z_yid))
                throw new Exception("lfkvjbbhdnvjfnvjfnvnf");
            list.Add(new item()
            {
                type = dv.GetType(),
                xid = dv.z_xid,
                yid = dv.z_yid
            });
            locker.Release();
        }
        async Task<Type> get(string xid, string yid)
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => i.xid == xid && i.yid == yid);
            locker.Release();
            return dv?.type;
        }
    }
}
