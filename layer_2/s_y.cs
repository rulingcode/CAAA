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
            a.o1.exchange_s = exchange;
        }
        async void exchange(byte[] data, layer_1.h_reply1 reply)
        {
            var packet = z_crypto.convert<m_packet>(data);
            var keys = await a.o2.s_get_key(packet.deviceid);
            if (packet.deviceid != null)
            {
                if (keys == null)
                    reply(null, e_reply.invalid_deviceid);
                try
                {
                    packet.data = z_crypto.Decrypt(packet.data, keys);
                }
                catch
                {
                    reply(null, e_reply.invalid_encryption);
                    return;
                }
            }
            var packet_y = z_crypto.convert<m_packet_y>(packet.data);
            var type = await get(packet.xid, packet_y.yid);
            if (type == null)
            {
                reply(null, e_reply.no_implement);
                return;
            }
            var y = JsonConvert.DeserializeObject(packet_y.data, type) as y;
            e_permission p = e_permission.non;
            if (packet.deviceid != null)
                p = (e_permission)Enum.Parse(typeof(e_permission), packet.deviceid[0].ToString());

            if (y.z_permission > p)
            {
                reply(null, e_reply.invalid_permission);
                return;
            }

            y.z_userid = packet_y.userid;
            y.run_s(met);
            void met(byte[] data, e_reply e)
            {
                if (data != null && keys != null)
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
