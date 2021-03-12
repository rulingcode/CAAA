using layer_0.x_center;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z_x_center.z
{
    class is_exist : y_is_exist
    {
        protected override async void implement()
        {
            var dv = await z_db.general_x<m.user>().any(i => i.id == a_userid);
            reply(new o() { yes = dv });
        }
    }
}
