using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns_Assign5Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Course c = new Course();

            c.Add(new Student("Joe"));
            c.Add(new Student("Bob"));

            foreach(Student stud in c)
            {
                Console.WriteLine(stud.Name);
            }

            while (Console.Read() != 'q') ;
        }
    }
}
