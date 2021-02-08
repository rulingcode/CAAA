using System;
using System.Collections.Generic;
using System.Text;

namespace layer_1
{
    public class m_keys1
    {
        public byte[] key32 { get; set; }
        public byte[] iv16 { get; set; }
        public static m_keys1 create(byte[] data) => new m_keys1()
        {
            key32 = z_crypto.split(data, 0, 32),
            iv16 = z_crypto.split(data, 32, 16)
        };
        public static byte[] create(m_keys1 rsv) => z_crypto.combine(rsv.key32, rsv.iv16);
    }
}
