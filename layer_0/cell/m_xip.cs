﻿using System.Net;
using Newtonsoft.Json;

namespace layer_0.cell
{
    public class m_xip
    {
        string dataf;
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
        [JsonIgnore] public IPEndPoint endpint => IPEndPoint.Parse(data);
        [JsonIgnore] public string address { get; private set; }
        [JsonIgnore] public int port { get; private set; }
        public override string ToString() => data;
        public static bool operator ==(m_xip a, m_xip b) => a?.data == b?.data;
        public static bool operator !=(m_xip a, m_xip b) => a?.data != b?.data;
        public override bool Equals(object obj) => (obj as m_xip)?.data == data;
        public override int GetHashCode() => 0;
    }
}