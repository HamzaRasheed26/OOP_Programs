using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircleProblem.BL;

namespace CircleProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Cylinder C1 = new Cylinder();
            Cylinder C2 = new Cylinder(5, 4);
            Cylinder C3 = new Cylinder(5, 3, "green");

            Console.WriteLine("Cylinder 1 Volume : " + C1.getVolume());
            Console.WriteLine("Cylinder 1 Height : " + C1.getHeight());
            Console.WriteLine("Cylinder 1 Color : " + C1.getColor());

            Console.WriteLine("Cylinder 2 Volume : " + C2.getVolume());
            Console.WriteLine("Cylinder 2 Height : " + C2.getHeight());
            Console.WriteLine("Cylinder 2 Color : " + C2.getColor());

            Console.WriteLine("Cylinder 3 Volume : " + C3.getVolume());
            Console.WriteLine("Cylinder 3 Height : " + C3.getHeight());
            Console.WriteLine("Cylinder 3 Color : " + C3.getColor());

            Console.WriteLine();
            string line = C1.makeString();
            Console.WriteLine(line);

            line = C2.makeString();
            Console.WriteLine(line);

            line = C3.makeString();
            Console.WriteLine(line);

            Console.ReadKey();
        }
    }
}
