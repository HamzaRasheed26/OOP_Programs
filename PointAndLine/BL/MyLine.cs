using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.BL
{
    internal class MyLine
    {
        private MyPoint begin = new MyPoint();
        private MyPoint end = new MyPoint();

        // Constructor
        public MyLine(MyPoint begin, MyPoint end)
        {
            this.begin = begin;
            this.end = end;
        }

        public MyLine()
        {
            begin.setXY(0, 0);
            end.setXY(0, 0);
        }

        // Member Function

        public MyPoint getBegin()
        {
            return begin;
        }

        public void setBegin(MyPoint begin)
        {
            this.begin = begin;
        }

        public MyPoint getEnd()
        {
            return end;
        }

        public void setEnd(MyPoint end)
        {
            this.end = end;
        }

        public double getLength()
        {
            double distance = begin.distanceFromObject(end);

            return distance;
        }

        public double getGradient()
        {
            double m;
            m = ((end.getY() - begin.getY()) / (end.getX() - begin.getX()));
            return m;
        }
    }
}
