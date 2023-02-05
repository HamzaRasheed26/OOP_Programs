using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeProblem.BL
{
    internal class MountainBike : Bicycle
    {
        private int seatHeight;

        public MountainBike(int seatHeight, int cadence, int gear, int speed) : base(cadence, gear , speed)
        {
            this.seatHeight = seatHeight;
        }

        public int getSeatHeight()
        {
            return seatHeight;
        }

        public void setSeatHeight(int seatHeight)
        {
            this.seatHeight = seatHeight;
        }
    }
}
