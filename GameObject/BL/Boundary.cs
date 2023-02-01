using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObject.BL
{
    internal class Boundary
    {
        private Point topLeft;
        private Point topRight;
        private Point bottomLeft;
        private Point bottomRight;

        // constructor

        public Boundary()
        {
            topLeft = new Point(0, 0);
            topRight = new Point(0, 90);
            bottomLeft = new Point(90, 0);
            bottomRight = new Point(90, 90);
        }

        public Boundary(Point topLeft, Point topRight, Point bottomLeft, Point bottomRight)
        {
            this.topLeft = topLeft;
            this.topRight = topRight;
            this.bottomLeft = bottomLeft;
            this.bottomRight = bottomRight;
        }

        public Point getTopLeft()
        {
            return topLeft;
        }
        public Point getTopRight()
        {
            return topRight;
        }
        public Point getBottomLeft()
        {
            return bottomLeft;
        }
        public Point getBottomRight()
        {
            return bottomRight;
        }

    }
}
