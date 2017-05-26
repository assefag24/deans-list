using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public decimal MathClass { get; set; }
        public decimal Science { get; set; }
        public decimal English { get; set; }
        public decimal French { get; set; }
        public decimal History { get; set; }
        public decimal Psychology { get; set; }
        public decimal GPA { get; set; }
        public string display
        {
            get
            {
                return string.Format("{0}, {1}:  Math: {2}, Science: {3}, English: {4}, French: {5}, History: {6}, Psychology: {7}, GPA: {8}", lastName, firstName, MathClass, Science, English, French, History, Psychology, GPA);
            }
        }
    }
}
