using layer_0.cell;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center.m
{
    /// <summary>
    /// id = userid
    /// </summary>
    class user : m_id
    {
        public string phoneid { get; set; }
        public string password { get; set; }
    }
}
