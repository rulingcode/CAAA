using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace layer_1
{
    public class m_x1
    {
        string endpointf;
        public string data
        {
            get => endpointf;
            set
            {
                endpointf = value;
                var dv = value.Split(':');
                address = dv[0];
                port = int.Parse(dv[1]);
            }
        }
        [JsonIgnore] public string address { get; private set; }
        [JsonIgnore] public int port { get; private set; }
        public override string ToString() => data;
        public static bool operator ==(m_x1 a, m_x1 b)
        {
            return a?.data == b?.data;
        }
        public static bool operator !=(m_x1 a, m_x1 b)
        {
            return a?.data != b?.data;
        }
        public override bool Equals(object obj)
        {
            var dv = obj as m_x1;
            return dv?.data == data;
        }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}