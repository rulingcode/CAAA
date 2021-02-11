using layer_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_2.implement
{
    class connect : y_connect
    {
        public override string z_xid => o2.x_center;
        public override string z_yid => nameof(y_connect);
        public override e_permission z_permission => e_permission.skelet;
        protected override async void implement(h_reply2<output> reply)
        {
            a_keys = z_crypto.Decrypt(a_keys, a.o2.key_s);
            var keys = m_key1.create(a_keys);
            a_login = z_crypto.Decrypt(a_login, keys);
            var login = z_crypto.convert<m_login>(a_login);
            if (await a.o2.check_password(login))
            {

            }
            reply(new output()
            {

            });

        }
    }
}
