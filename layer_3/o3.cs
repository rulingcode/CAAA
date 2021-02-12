using layer_1;
using layer_2;
using System;
using System.Threading.Tasks;

namespace layer_3
{
    public class o3
    {
        #region constructor
        o3()
        {
            a.o3 = this;
            a.o2 = o2.create();
            a.o2.c_get_key = get_key_c;
            a.o2.s_get_key = get_key_s;
        }
        public static o3 create() => a.o3 == null ? new o3() : null;
        #endregion

        #region implement
        private Task<m_key> get_key_s(string deviceid)
        {
            throw new NotImplementedException();
        }
        private Task<m_key> get_key_c()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region new
        public byte[] public_key { get;  set; }
        public byte[] private_key { get; set; }
        public c_create_device create_device_c { get; set; }
        public s_create_deviceid create_device_s { get; set; }
        public s_remove_deviceid remove_device_s { get; set; }
        public Task start() => a.start.run();
        #endregion

        #region overwrite
        public h_report report { get => a.o2.report; set => a.o2.report = value; }
        public m_x x_m { get => a.o2.x_m; set => a.o2.x_m = value; }
        public void add_x(m_x rsv) => a.o2.add_x(rsv);
        public void add_y<T>() where T : y, new() => a.o2.add_y<T>();
        public c_run run(string userid = null) => a.o2.run(userid);
        public Task<e_error> add_user(string userid, string password)
        {
            return default;
        }
        #endregion   
    }
}
