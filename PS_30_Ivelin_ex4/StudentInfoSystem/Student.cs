using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    internal class Student
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

        public Student() { }
    }
}