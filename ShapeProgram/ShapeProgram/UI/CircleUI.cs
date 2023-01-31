using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.BL;

namespace ShapeProgram.UI
{
    internal class CircleUI
    {
        public static Circle createShape()
        {
            Console.Write("Enter Radius : ");
            double radius = double.Parse(Console.ReadLine());

            Circle c = new Circle(radius);
            return c;
        }
    }
}
