using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeProgram.BL;

namespace ShapeProgram.DL
{
    internal class ShapeDL
    {
        private static List<Shape> shapesList = new List<Shape>();

        public static void addIntoList(Shape s)
        {
            shapesList.Add(s);
        }

        public static List<Shape> getList()
        {
            return shapesList;
        }
    }
}
