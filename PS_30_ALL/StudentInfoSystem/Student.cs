using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    /*
    public class Student
    {
        public string fName { get; set; }
        public string mName { get; set; }
        public string lName { get; set; }
        public string fac { get; set; }
        public string spec { get; set; }
        public string degr { get; set; }
        public string stat { get; set; }
        public string Fnum { get; set; }
        public int course { get; set; }
        public int stream { get; set; }
        public int group { get; set; }

        public Student(string fName, string mName, string lName, string fac, string spec, string degr, string stat, string Fnum, int course, int stream, int group)
        {
            this.fName = fName;
            this.mName = mName;
            this.lName = lName;
            this.fac = fac;
            this.spec = spec;
            this.degr = degr;
            this.stat = stat;
            this.Fnum = Fnum;
            this.course = course;
            this.stream = stream;
            this.group = group;
        }
    */

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FamilyName { get; set; }
        public byte[] Photo { get; set; }
        public string Faculty { get; set; }
        public string Specialty { get; set; }
        public int Course { get; set; }
        public string Degree { get; set; }

        public string Status { get; set; }

        public int Stream { get; set; }
        public int Group { get; set; }

        public int StudentId { get; set; }
        public object FacultyNumber { get; internal set; }
    }
}