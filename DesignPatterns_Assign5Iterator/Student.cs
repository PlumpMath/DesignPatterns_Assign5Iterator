using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Assign5Iterator
{
    struct Student
    {
        private string _name;

        public Student(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
