using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.BL;

namespace ShapeProgram.UI
{
    internal class SquareUI
    {
        public static Square createShape()
        {
            Console.Write("Enter Side : ");
            int side = int.Parse(Console.ReadLine());

            Square s = new Square(side);
            return s;
        }
    }
}
