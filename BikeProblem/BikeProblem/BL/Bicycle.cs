using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProblem.BL
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        }

        public int getCadence()
        {
            return cadence;
        }
        public int getGear()
        {
            return gear;
        }
        public int getSpeed()
        {
            return speed;
        }

        public void setCadence(int cadence)
        {
            this.cadence = cadence;
        }
        public void setGear(int gear)
        {
            this.gear = gear;
        }

        public void applyBrake(int decrement)
        {
            speed = speed - decrement;
        }

        public void speedUp(int increment)
        {
            speed = speed + increment;
        }
    }
}
