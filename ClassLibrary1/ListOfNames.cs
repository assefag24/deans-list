using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ListOfNames
    {
        public List<Student> allStudents { get; set; }

        public ListOfNames()
        {
            allStudents = new List<Student>();
        }

        public void Sort(Func<object, object, int> p)
        {
            throw new NotImplementedException();
        }
    }
}
