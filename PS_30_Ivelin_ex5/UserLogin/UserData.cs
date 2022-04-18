using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    static class UserData
    {
        private static List<User> _testUser = new List<User>();
        public static List<User> TestUser
        {
            get
            {
                ResetTestUserData();
                return _testUser;
            }
            set { }
        }
        public static User IsUserPassCorrect(string username, string password)
        {
            IEnumerable<User> users = (from user in TestUser
                                       where user.UName.Equals(username) && user.Pass.Equals(password)
                                       select user).ToList();

            return users.FirstOrDefault();
        }
        public static void SetUserActiveTo(string username, DateTime dateValidTo)
        {

            foreach (var user in TestUser)
            {
                if (username.Equals(user.UName))
                {
                    user.Valid = dateValidTo;
                    Logger.LogActivity("Changed expiration date of: " + username);
                }
            }

        }
        public static void AssignUserRole(string username, UserRoles newRole)
        {
            foreach (var user in TestUser)
            {
                if (username.Equals(user.UName))
                {
                    user.Role = newRole;
                    Logger.LogActivity("Changed role of " + username);
                }
            }
        }
        public static void ResetTestUserData()
        {
            if (_testUser.Count == 0)
            {
                _testUser.Add(new User());
                _testUser[0].UName = "Admin_";
                _testUser[0].Pass = "Admin_";
                _testUser[0].Faknum = "121219000";
                _testUser[0].Crea = DateTime.Now;
                _testUser[0].Valid = DateTime.MaxValue;
                _testUser[0].Role = UserRoles.ADMIN;

                _testUser.Add(new User());
                _testUser[1] = new User();
                _testUser[1].UName = "Nqkoi1";
                _testUser[1].Pass = "123456";
                _testUser[1].Faknum = "121219002";
                _testUser[1].Crea = DateTime.Now;
                _testUser[1].Valid = DateTime.MaxValue;
                _testUser[1].Role = UserRoles.STUDENT;

                _testUser.Add(new User());
                _testUser[2] = new User();
                _testUser[2].UName = "Nqkoi2";
                _testUser[2].Pass = "0000000";
                _testUser[2].Faknum = "121219003";
                _testUser[2].Crea = DateTime.Now;
                _testUser[2].Valid = DateTime.MaxValue;
                _testUser[2].Role = UserRoles.STUDENT;
            }
        }

    }
}
