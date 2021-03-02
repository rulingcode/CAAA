﻿using layer_0;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using layer_0.cell;
using WatsonTcp;

namespace layer_1.c
{
    class exchange_pool
    {
        SemaphoreSlim locker = new SemaphoreSlim(1, 1);
        public m_xip x_m { get; }
        internal async void close()
        {
            await locker.WaitAsync();
            foreach (var i in list)
                i.close();
            list.Clear();
            locker.Release();
        }
        public exchange_pool(m_xip x_m) => this.x_m = x_m;

        List<exchange_item> list = new List<exchange_item>();
        async Task<exchange_item> get()
        {
            await locker.WaitAsync();
            var dv = list.FirstOrDefault(i => !i.inp);
            if (dv == null)
            {
                dv = new exchange_item(x_m);
                list.Add(dv);
            }
            dv.inp = true;
            locker.Release();
            return dv;
        }
        SemaphoreSlim n_locker = new SemaphoreSlim(8, 8);
        public async Task<byte[]> send(byte[] data)
        {
            await n_locker.WaitAsync();
            var dialog = await get();
            var dv = await dialog.send(data);
            dialog.inp = false;
            n_locker.Release();
            return dv;
        }
    }
}