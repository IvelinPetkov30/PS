using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class StudentData
    {
        private static List<Student> _testStudents = new List<Student>();
        public static List<Student> TestStudents
        {
            get
            {
                studentsData();
                return _testStudents;
            }
            set { }
        }

        public static void studentsData()
        {
            _testStudents.Add(new Student());
            _testStudents[0].fName = "Ivan";
            _testStudents[0].mName = "Ivanov";
            _testStudents[0].lName = "Ivanov";
            _testStudents[0].fac = "FCST";
            _testStudents[0].spec = "KSI";
            _testStudents[0].degr = "Bakalavar";
            _testStudents[0].stat = "AC";
            _testStudents[0].Fnum = "121219001";
            _testStudents[0].course = 3;
            _testStudents[0].stream = 1;
            _testStudents[0].group = 30;

            _testStudents.Add(new Student());
            _testStudents[1].fName = "Dimitar";
            _testStudents[1].mName = "Dimitrov";
            _testStudents[1].lName = "Dimitrov";
            _testStudents[1].fac = "FCST";
            _testStudents[1].spec = "KSI";
            _testStudents[1].degr = "Bakalavar";
            _testStudents[1].stat = "AC";
            _testStudents[1].Fnum = "121219002";
            _testStudents[1].course = 2;
            _testStudents[1].stream = 1;
            _testStudents[1].group = 31;



        }

    }
}
