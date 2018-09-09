using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classroom = new ClassRoom();

            classroom.classname = "3B";
            classroom.semesterstart = new DateTime(2018, 9, 4);
            classroom.classlist = new List<Student>();

            Student studentOne = new Student("Mads", 2, 3);
            Student studentTwo = new Student("Bastian", 7, 17);
            Student studentThree = new Student("Michael", 12, 29);


        }
    }
}
