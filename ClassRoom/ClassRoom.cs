using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    class ClassRoom
    {
        public string classname { get; set; }
        public List<Student> classlist = new List<Student>();
        public DateTime semesterstart { get; set; }

        public ClassRoom()
        {

        }
    }
   
}
