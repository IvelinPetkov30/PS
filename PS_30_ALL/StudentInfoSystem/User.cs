using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{

        public class User
        {
            public System.String Username
            {
                get;
                set;
            }
            public System.String Password
            {
                get;
                set;
            }
            public System.String FakNum
            {
                get;
                set;
            }
            public System.Int32 Role
            {
                get; set;
            }
            public System.DateTime Created
            {
                get;
                set;
            }
            public System.DateTime? ActiveTo
            {
                get; set;
            }
        public System.Int32 UserId { get; set; }
        
    }
    
}

