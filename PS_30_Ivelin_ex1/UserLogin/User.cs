using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class User
    {
        public String UName { get; set; }
        public String Pass { get; set; }
        public String Faknum { get; set; }
        public int Role { get; set; }

        public User(string UName, string Pass, string Faknum, int Role)
        {
            this.UName = UName;
            this.Pass = Pass;
            this.Faknum = Faknum; 
            this.Role = Role;
        }

        public User()
        {
            UName = "";
            Pass = "";
            Faknum = "" ;
            Role = 0;

        }



    }
}
