using layer_0.cell;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace layer_0.x_user
{
    public class y_upsert_name : z_y<y_upsert_name.o>
    {
        public override string z_yid => nameof(y_upsert_name);
        public string a_fullname { get; set; }
        public class o : o<error> { }
    }
    public enum error
    {
        non,
        permission_required
    }
}
