using layer_1;
using layer_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_dna
{
    public class keys
    {
        private const string device_message = "device_message";
        private const string device1 = "device1";
        public static m_x x_m = new m_x() { data = res.get_endpoint(10000).ToString(), id = "x_center" };

        public static m_key message = new m_key()
        {
            deviceid = device_message,
            key32 = new byte[] { 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 11, 77 },
            iv16 = new byte[] { 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 88, 66, 55, 44, 33, 22 }
        };
        public static m_key client = new m_key()
        {
            deviceid = device1,
            key32 = new byte[] { 12, 22, 33, 44, 55, 66, 77, 54, 11, 22, 12, 22, 33, 44, 98, 66, 77, 88, 11, 11, 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 11, 77 },
            iv16 = new byte[] { 12, 22, 33, 44, 55, 66, 77, 88, 11, 22, 88, 66, 55, 44, 33, 22 }
        };

        public static async Task<bool> check(string deviceid, string userid)
        {
            switch (deviceid)
            {
                case device_message: return userid == "x_message";
                case device1: return userid == "u_ali";
            }
            return await Task.FromResult(false);
        }
        public static async Task<m_key> get_key_s(string deviceid)
        {
            await Task.CompletedTask;
            switch (deviceid)
            {
                case device_message: return message;
                case device1: return client;
            }
            return null;
        }
    }
}
