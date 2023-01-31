using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeProgram.BL
{
    internal class Shape
    {
        protected string type;

        public Shape(string type)
        {
            this.type = type;
        }

        public void setType(string type)
        {
            this.type = type;
        }
        public virtual string getShapeType()
        {
            return "undefined";
        }

        public virtual double getArea()
        {
            return 0;
        }
    }
}
