using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireDepartement.BL
{
    internal class FireTruck
    {
        private Ladder l;
        private HosePipe pipe;
        private FireFighter driver;

        public FireTruck(HosePipe pipe, FireFighter driver)
        {
            l = new Ladder(55, "White");
            this.pipe = pipe;
            this.driver = driver;
        }

        public Ladder getLadder()
        {
            return l;
        }
        public HosePipe GetHosePipe()
        {
            return pipe;
        }
        public FireFighter GetFireFighter()
        {
            return driver;
        }

        public void setLadder(Ladder l)
        {
            this.l = l;
        }
        public void setHosePipe(HosePipe pipe)
        {
            this.pipe = pipe;
        }
        public void setFireFighter(FireFighter driver)
        {
            this.driver = driver;
        }
    }
}
