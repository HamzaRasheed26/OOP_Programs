using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.BL;

namespace ShapeProgram.UI
{
    internal class ShapeUI
    {
        public static void showAreas(List<Shape> shapesList)
        {
            foreach(Shape s in shapesList)
            {
                double area = s.getArea();
                string type = s.getShapeType();

                Console.WriteLine("The shape is " + type + " and its area is " + area);
            }
        }
    }
}
