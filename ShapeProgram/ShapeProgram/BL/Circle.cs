using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgram.BL
{
    internal class Circle : Shape
    {
        private double radius;

        public Circle(double radius) : base("Circle")
        {
            this.radius = radius;
        }

        public double getRadius()
        {
            return radius;
        }
        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public override string getShapeType()
        {
            return "Circle";
        }

        public override double getArea()
        {
            double area = 0;
            area = 2 * Math.PI * radius * radius;
            return area;
        }
    }
}
