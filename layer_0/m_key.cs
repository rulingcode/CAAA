﻿using System;
using System.Collections.Generic;
using System.Text;

namespace layer_0
{
    public class m_key
    {
        public string id { get; set; }
        public byte[] key32 { get; set; }
        public byte[] iv16 { get; set; }
        public static m_key create(byte[] data) => new m_key()
        {
            key32 = p_crypto.split(data, 0, 32),
            iv16 = p_crypto.split(data, 32, 16)
        };
        public static byte[] create(m_key rsv) => p_crypto.combine(rsv.key32, rsv.iv16);
    }
}
