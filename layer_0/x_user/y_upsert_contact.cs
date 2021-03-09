using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_user
{
    public class y_upsert_contact : z_y<y_upsert_contact.o>
    {
        public override string z_yid => nameof(y_upsert_contact);
        public string a_partner_id { get; set; }
        public bool a_contact { get; set; }
        public class o : o_base<error> { }
    }
    public enum error
    {
        non,
        invalid_partner_id,
        invalid_parametrs
    }
}
