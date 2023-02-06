using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentProblem.BL;

namespace StudentProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // For Day Scholar

            DayScholar std = new DayScholar("Hamza", "2021", true, 173, 1061, "BankStop", "7", 22);

            Console.WriteLine(std.getName() + " is Allocated Bus " + std.getBusNo());

            // For Hostelite

            Hostelite std2 = new Hostelite("Tahir", "2021", false, 200, 1070, 3, false, true);

            Console.WriteLine(std2.getName() + " is Allocated Room " + std2.getRoomNumber());

            Console.ReadKey();


        }
    }
}
