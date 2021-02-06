using System;
using System.Globalization;
using System.Net;
using System.Net.Sockets;

namespace layer_1
{
    public class res
    {
        public static bool islocal { get; set; } = true;
        public static string validip { get; set; }
        public static IPEndPoint get_endpoint(int port)
        {
            return new IPEndPoint(getip(), port);
        }
        static IPAddress getip()
        {
            if (islocal)
                return localip();
            else
                return IPAddress.Parse(validip);
        }
        public static IPEndPoint convert(string endPoint)
        {
            string[] ep = endPoint.Split(':');
            if (ep.Length != 2) throw new FormatException("Invalid endpoint format");
            IPAddress ip;
            if (!IPAddress.TryParse(ep[0], out ip))
            {
                throw new FormatException("Invalid ip-adress");
            }
            int port;
            if (!int.TryParse(ep[1], NumberStyles.None, NumberFormatInfo.CurrentInfo, out port))
            {
                throw new FormatException("Invalid port");
            }
            return new IPEndPoint(ip, port);
        }
        static IPAddress localip()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
    }
}