using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    internal class Angle
    {
        private int degrees;
        private float minutes;
        private char direction;

        // constructur
        public Angle(int degrees, float minutes, char dirction)
        {
            this.degrees = degrees;
            this.minutes = minutes;
            this.direction = dirction;
        }

        public int getDegrees()
        {
            return degrees;
        }
        public float getMinutes()
        {
            return minutes;
        }
        public char getDirection()
        {
            return direction;
        }

        public bool isSame(Angle temp)
        {
            if( temp.degrees == degrees && temp.minutes == minutes && temp.direction == direction )
            {
                return true;
            }
            return false;
        }
    }
}
