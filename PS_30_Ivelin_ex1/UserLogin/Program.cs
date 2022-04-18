using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            LoginValidation loginVal = new LoginValidation();
            if (loginVal.ValidateUserInput())
            {
                Console.WriteLine(UserData.TestUser.UName);
                Console.WriteLine(UserData.TestUser.Pass);
                Console.WriteLine(UserData.TestUser.Faknum);
                Console.WriteLine(UserData.TestUser.Role);

            }
        }
    }
}
