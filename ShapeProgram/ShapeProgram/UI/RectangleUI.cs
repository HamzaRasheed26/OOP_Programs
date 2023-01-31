using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.BL;

namespace ShapeProgram.UI
{
    internal class RectangleUI
    {
        public static Rectangle createShape()
        {
            Console.Write("Enter Width : ");
            int width = int.Parse(Console.ReadLine());

            Console.Write("Enter Height : ");
            int height = int.Parse(Console.ReadLine());

            Rectangle r = new Rectangle(width, height);
            return r;
        }
    }
}
