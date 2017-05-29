using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
   public class Game
    {
        public string username { get; set; }
        public string password { get; set; }
        public List<Student> allStudent { get; set; }
        public Game()
        {
            allStudent = new List<Student>();
        }
    }
}
