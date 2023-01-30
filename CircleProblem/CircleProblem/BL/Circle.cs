using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleProblem.BL
{
    internal class Circle
    {
        protected double radius = 1.0;
        protected string color = "red";

        public Circle()
        {
            radius = 1.0;
            color = "red";
        }

        public Circle(double radius)
        {
            this.radius = radius;
            color = "red";
        }

        public Circle(double radius, string color)
        {
            this.radius = radius;
            this.color = color;
        }

        public double getRadius()
        {
            return radius;
        }

        public string getColor()
        {
            return color;
        }

        public void setRadius(double radius)
        {
            this.radius = radius;
        }

        public void setColor(string color)
        {
            this.color = color;
        }

        public double getArea()
        {
            double area = 0.0;
            area = 2 * Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public virtual string makeString()
        {
            string line = "Circle[ radius = " + radius.ToString() + " color = " + color.ToString() + "]";
            return line;
        }
    }
}
