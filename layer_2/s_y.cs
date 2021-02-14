﻿using layer_1;
using layer_2.implement;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace layer_2
{
    class s_y
    {
        List<item> list = new List<item>();
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        class item
        {
            public string xid { get; set; }
            public string yid { get; set; }
            public Type type { get; set; }
        }
        public s_y()
        {
            a.o1.y_s = y_s;
        }
        async void y_s(byte[] data, s_reply reply)
        {
            var packet = z_crypto.convert<m_packet>(data);
            var keys = await a.o2.s_get_key(packet.deviceid);
            if (packet.deviceid != null)
            {
                if (keys == null)
                    met(null, e_error.invalid_deviceid);
                try
                {
                    packet.data = z_crypto.Decrypt(packet.data, keys);
                }
                catch
                {
                    met(null, e_error.invalid_encryption);
                    return;
                }
            }
            var packet_y = z_crypto.convert<m_packet_y>(packet.data);
            var type = await get(packet.xid, packet_y.yid);
            if (type == null)
            {
                met(null, e_error.no_implement);
                return;
            }
            var y = JsonConvert.DeserializeObject(packet_y.data, type) as y;
            e_permission p = 0;
            if (packet.deviceid == null)
            {
                p = e_permission.non;
                if (packet_y.userid != null)
                {
                    met(null, e_error.invalid_userid);
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
                            met(null, e_error.invalid_userid_prefix);
                            return;
                    }
            }
            if (y.z_permission > p)
            {
                met(null, e_error.invalid_permission);
                return;
            }
            if (packet_y.userid != null && !await a.o2.check_userid_s(packet.deviceid, packet_y.userid))
            {
                met(null, e_error.invalid_userid);
                return;
            }
            y.z_userid = packet_y.userid;
            y.z_deviceid = packet.deviceid;
            y.run_s(met);
            void met(byte[] data, e_error e)
            {
                if (data == null)
                {
                    y_output obj = new y_output() { z_error = e };
                    data = z_crypto.convert(obj);
                }

                if (keys != null)
                    data = z_crypto.Encrypt(data, keys);
                reply(data, e);
            }
        }
        internal async void add_y<T>() where T : y, new()
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
