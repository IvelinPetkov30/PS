using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    class Program
    {
        static bool changeRole()
        {
            UserRoles newRole;
            Console.Write("\nUser name: ");
            string username = Console.ReadLine();
            Console.Write("New role of the user (integer): ");
            newRole = (UserRoles)int.Parse(Console.ReadLine());
            UserData.AssignUserRole(username, (UserRoles)newRole);
            Console.WriteLine("Role changed!");
            return true;
        }

        static void changeDate()
        {
            Console.Write("\nUser name: ");
            string username = Console.ReadLine();
            Console.Write("New expiration date of the registration: ");
            string newValidationDate = Console.ReadLine();
            UserData.SetUserActiveTo(username, Convert.ToDateTime(newValidationDate));
        }

        static string showLog()
        {
            string content = File.ReadAllText("test.txt");
            return content;
        }

        static void printUser()
        {
            foreach (var user1 in UserData.TestUser)
            {
                Console.WriteLine("\nUsername:" + user1.UName);
                Console.WriteLine("Password:" + user1.Pass);
                Console.WriteLine("Faculty number:" + user1.Faknum);
                Console.WriteLine("User role:" + user1.Role);
                Console.WriteLine("Created:" + user1.Crea);
                Console.WriteLine("Valid Until:" + user1.Valid);
            }

        }

        static void adminMenu()
        {
            Console.WriteLine("\nChoose option:");
            Console.WriteLine("1: Change user role");
            Console.WriteLine("2: Change user expire validation");
            Console.WriteLine("3: Print all users");
            Console.WriteLine("4: Logging activity preview");
            Console.WriteLine("5: Current logging activity preview");
            Console.WriteLine("0: Exit");

            int choice = new int();

            while (choice != null)
            {
                choice = int.Parse(Console.ReadLine());
                if (choice == 0)
                {
                    Console.WriteLine("Exiting...");
                    break;
                }
                else if (choice == 1)
                {
                    Console.WriteLine("Changing user role: ");
                    changeRole();

                }
                else if (choice == 2)
                {
                    Console.WriteLine("Changing user expire validation: ");
                    changeDate();
                }
                else if (choice == 3)
                {
                    Console.WriteLine("All users: ");
                    printUser();

                }
                else if (choice == 4)
                {
                    Console.WriteLine(showLog());
                }
                else if (choice == 5)
                {
                    Console.WriteLine(Logger.GetCurrentSessionActivity());
                }
                else { Console.WriteLine("Invalid choice!"); }

            }
            return;
        }

        static void errorFunc(string errorMsg)
        {
            Console.WriteLine(errorMsg);
        }

        static void Main(string[] args)
        {
            User user = new User();
            Console.WriteLine("Enter username: ");
            string user_name = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();
            LoginValidation logVal = new LoginValidation(user_name, password, errorFunc);
            UserData.ResetTestUserData();

            if (logVal.validateUserInput(ref user))
            {
                Console.WriteLine("\nUsername:" + user.UName);
                Console.WriteLine("Password:" + user.Pass);
                Console.WriteLine("Faculty number:" + user.Faknum);
                Console.WriteLine("Role: " + user.Role);
                Console.WriteLine("Created:" + user.Crea);
                Console.WriteLine("Valid Until:" + user.Valid);
            }

            switch (LoginValidation.currentUserRole)
            {
            case UserRoles.ANONYMOUS:
                {
                Console.WriteLine("User has no role or is not logged in.");
                break;
                }
            case UserRoles.ADMIN:
                {
                Console.WriteLine("User is an admin.");
                adminMenu();
                break;
                }
            case UserRoles.INSPECTOR:
                {
                Console.WriteLine("User is an inspector.");
                break;
                }
            case UserRoles.PROFESSOR:
                {
                Console.WriteLine("User is a professor.");
                break;
                }
            case UserRoles.STUDENT:
                {
                Console.WriteLine("User is a student.");
                break;
                }
            }
        }
    }
}
