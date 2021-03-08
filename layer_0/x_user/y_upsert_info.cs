using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_user
{
    public class y_upsert_info : z_y<y_upsert_info.o>
    {
        public override string z_yid => nameof(y_upsert_info);
        public string a_full_name { get; set; }
        public string a_national_id { get; set; }
        public e_status a_status { get; set; }
        public string a_phoneid { get; set; }
        public class o : o_base<error> { }
        public enum error
        {
            non,
            permission_required,
            duplicate_name
        }
    }
}
