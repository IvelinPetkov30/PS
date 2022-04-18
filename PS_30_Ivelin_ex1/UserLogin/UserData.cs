using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {

        static private User _testUser;
        public static User TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }

        private static void ResetTestUserData()
        {
            if (_testUser == null)
            {
                _testUser = new User();
                _testUser.UName = "Test";
                _testUser.Pass = "Test";
                _testUser.Faknum = "121219001";
                _testUser.Role = 1;
            }
        }

    }
}
