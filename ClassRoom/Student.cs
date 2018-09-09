using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string name;
        private int birthmonth;
        private int birthday;

        public Student(string studentName, int studentBirthmonth, int studentBirthday)
        {
            studentName = name;
            studentBirthmonth = birthmonth;
            studentBirthday = birthday;
        }

        public string studentName { get; }
        public int studentBirthmonth { get; }
        public int studentBirthday { get; }
    }
}
