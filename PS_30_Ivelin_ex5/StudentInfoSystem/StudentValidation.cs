using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentInfoSystem
{

    internal class StudentValidation
    {

        Student GetStudentDataByUser(UserLogin.User user)
        {

            Student student = new Student();

            if (user.Faknum == null || !user.Faknum.Equals(user.Faknum))
            {
                Console.WriteLine("No student with this fac. number !");

                return null;
            }

            return (from s in StudentData.TestStudents where s.Fnum == user.Faknum select s).First();
        }

    }

}
