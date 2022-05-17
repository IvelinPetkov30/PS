using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    public class User
    {
        public String UName { get; set; }
        public String Pass { get; set; }
        public String Faknum { get; set; }
        public DateTime Crea { get; set; }
        public DateTime Valid { get; set; }
        public UserRoles Role { get; set; }

        public User(string UName, string Pass, string Faknum, DateTime Crea, DateTime Valid, UserRoles Role)
        {
            this.UName = UName;
            this.Pass = Pass;
            this.Faknum = Faknum;
            this.Crea = Crea;
            this.Valid = Valid;
            this.Role = Role;
        }

        public User()
        {
            UName = "";
            Pass = "";
            Faknum = "" ;
            Crea = DateTime.Now;
            Valid = DateTime.MaxValue;
            Role = 0;

        }



    }
}
