using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace layer_1
{
    public class c_m_x
    {
        public string id { get; set; }
        string dataf;
        public IPEndPoint endpint => IPEndPoint.Parse(data);

        public string data
        {
            get => dataf;
            set
            {
                dataf = value;
                var dv = value.Split(':');
                address = dv[0];
                port = int.Parse(dv[1]);
            }
        }
        [JsonIgnore] public string address { get; private set; }
        [JsonIgnore] public int port { get; private set; }
        public override string ToString() => data;
        public static bool operator ==(c_m_x a, c_m_x b) => a?.data == b?.data;
        public static bool operator !=(c_m_x a, c_m_x b) => a?.data != b?.data;
        public override bool Equals(object obj) => (obj as c_m_x)?.data == data;
        public override int GetHashCode() => 0;
    }
}