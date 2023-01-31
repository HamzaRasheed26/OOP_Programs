using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgram.BL
{
    internal class Rectangle : Shape
    {
        private int width;
        private int height;

        public Rectangle(int width, int height) : base("Rectangle")
        {
            this.width = width;
            this.height = height;
        }

        public int getWidth()
        {
            return width;
        }
        public int getHeight()
        {
            return height;
        }

        public void setWidth(int width)
        {
            this.width = width;
        }
        public void setHeight(int height)
        {
            this.height = height;
        }

        public override string getShapeType()
        {
            return "Rectangle";
        }

        public override double getArea()
        {
            double area = 0;
            area = width * height;
            return area;
        }
    }
}
