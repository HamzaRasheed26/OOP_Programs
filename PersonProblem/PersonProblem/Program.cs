using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonProblem.BL;

namespace PersonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" Students ");

            Student s1 = new Student("Hamza", "Lahore", "CS", 2021, 50000);
            Student s2 = new Student("Ali", "Sahiwal", "ME", 2019, 70000);

            Console.WriteLine(s1.makeString());
            Console.WriteLine(s2.makeString());

            Console.WriteLine(" Staff ");

            Staff teacher = new Staff("Talha", "Lahore", "Fast Academy", 30000);
            Staff teacher2 = new Staff("Ahmed", "Karachi", "ASF", 40000);

            Console.WriteLine(teacher.makeString());
            Console.WriteLine(teacher2.makeString());

            Console.ReadKey();
        }
    }
}
