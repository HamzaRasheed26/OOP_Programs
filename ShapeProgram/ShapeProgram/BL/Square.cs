using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgram.BL
{
    internal class Square : Shape
    {
        private int side;

        public Square(int side) : base("Square")
        {
            this.side = side;
        }

        public int getSide()
        {
            return side;
        }
        public void setSide(int side)
        {
            this.side = side;
        }

        public override string getShapeType()
        {
            return "Square";
        }

        public override double getArea()
        {
            double area = 0;
            area = Math.Pow(side, 2);
            return area;
        }
    }
}
