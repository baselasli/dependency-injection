using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace testone.Controllers.model
{
    public class Users
    {

        public int id { get; set; }
        public String name { get; set; }
        public DateTime dop { get; set; }
        public String phone { get; set; }
        public String email { get; set; }

        public Users(int id, string name, DateTime dop, string phone, string email)
        {
            this.id = id;
            this.name = name;
            this.dop = dop;
            this.phone = phone;
            this.email = email;
        }
    }
}
