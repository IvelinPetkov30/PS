using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogin
{
    internal class LoginValidation
    {
        private string uname;
        private string pass;
        private string error;


        public static UserRoles currentUserRole { get; private set; }


        public LoginValidation(string uname, string pass, ActionOnError onError)
        {
            this.uname = uname;
            this.pass = pass;
            this.onError = new ActionOnError(onError);
        }


        public static string currentUserUsername { get; private set; }
        public delegate void ActionOnError(string errorMsg);
        private ActionOnError onError;


        public Boolean validateUserInput(ref User user1)
        {

            Boolean emptyUsername;
            emptyUsername = uname.Equals(String.Empty);
            if (emptyUsername)
            {
                error = "Username not specified";
                onError(error);
                return false;
            }

            Boolean shortUsername;
            shortUsername = uname.Length < 5;
            if (shortUsername)
            {
                error = "Username too short";
                onError(error);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            Boolean emptyPassword;
            emptyPassword = pass.Equals(String.Empty);
            if (emptyPassword)
            {
                error = "Password not specified";
                onError(error);
                return false;
            }

            Boolean shortPassword;
            shortPassword = pass.Length < 5;
            if (shortPassword)
            {
                error = "Password too short";
                onError(error);
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }

            user1 = UserData.IsUserPassCorrect(uname, pass);
            if (user1 != null)
            {
                currentUserRole = (UserRoles)user1.Role;
                currentUserUsername = uname;
                Logger.LogActivity("Successful Login");
                return true;
            }
            else
            {
                error = "Not such user found!";
                onError(error);
                currentUserUsername = null;
                currentUserRole = UserRoles.ANONYMOUS;
                return false;
            }
        }
    }
}
