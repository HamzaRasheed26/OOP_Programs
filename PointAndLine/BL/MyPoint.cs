using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointAndLine.BL
{
    internal class MyPoint
    {

        private int x;
        private int y;

        // COnstructur
        public MyPoint()
        {

        }

        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        // Member Functions

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public double distanceWithCords(int x1, int y1)
        {
            return Math.Sqrt(((x - x1) * (x - x1)) + ((y - y1) * (y - y1)));
        }

        public double distanceFromObject(MyPoint point)
        {
            double xValue = Math.Pow((x - point.x), 2);
            double yValue = Math.Pow((y - point.y), 2);

            double distance = Math.Sqrt(xValue + yValue);

            return distance;
        }

        public double distanceFromZero()
        {
            double xValue = Math.Pow((x - 0), 2);
            double yValue = Math.Pow((y - 0), 2);

            double distance = Math.Sqrt(xValue + yValue);

            return distance;
        }
    }
}

