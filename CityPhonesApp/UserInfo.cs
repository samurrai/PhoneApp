using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityPhonesApp
{
    public class UserInfo : Entity
    {
        public string PhoneNumber { get; set; }
        public string Info { get; set; }
        public virtual City City { get; set; }
    }
}
