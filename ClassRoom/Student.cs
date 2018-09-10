using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Student
    {
        private string name { get; set; }
        private int birthmonth { get; set; }
        private int birthday { get; set; }
    
        public Student(string studentName, int studentBirthmonth, int studentBirthday)
        {
            name = studentName;
            birthmonth = studentBirthmonth;
            birthday = studentBirthday;
        }

        
        public string studentName { get; }
        public int studentBirthmonth { get; }
        public int studentBirthday { get; }

        public string Season(int birthmonth)
        {
            // Skulle have brugt <=, >= istedet her. 
            if (birthmonth == 1 || birthmonth == 2 || birthmonth == 12)
            { return "Winter";}

            if (birthmonth == 3 || birthmonth == 4 || birthmonth == 5)
            { return "Spring";}

            if (birthmonth == 6 || birthmonth == 7 || birthmonth == 8)
            {return "Summer";}

            if (birthmonth == 9 || birthmonth == 10 || birthmonth == 11)
            {return "Autumn";}

            return null;
        }


    }
    }

