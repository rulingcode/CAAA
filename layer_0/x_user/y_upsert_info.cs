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
        public string a_userid { get; set; }
        public string a_name { get; set; }
        public string a_national_code { get; set; }
        public e_status a_state { get; set; }
        public string a_phoneid { get; set; }
        public e_gender a_gender { get; set; }
        public class o : o_base<error> { }
        public enum error
        {
            non,
            invalid_userid,
            invalid_name,
            duplicate_name,
            invalid_national_code,
            duplicate_code,
            invalid_state,
            invalid_phoneid,
            license_required,
        }
    }
}
