using layer_0.cell;
using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using z_x_center.data_model;

namespace z_x_center.implement
{
    class send_code : y_send_code
    {
        protected async override void implement(s_reply<output> reply)
        {
            var db = z_db.a_x<m_phone>();
            var dv = await db.get(a_phoneid);
            if (dv == null)
            {
                dv = new m_phone()
                {
                    id = a_phoneid,
                    password = p_crypto.random.Next(10000, 99999).ToString()
                };
                await db.upsert(dv);
            }
            MessageBox.Show(dv.password);
        }
    }
}
