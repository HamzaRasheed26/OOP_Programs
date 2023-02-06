using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem.BL
{
    internal class DayScholar : Student
    {
        private string pickUpPoint;
        private string BusNo;
        private float pickUpDistance;

        public DayScholar(string name, string session, bool isDayScholar, float EntryTestMarks, float HSMarks, string pickUpPoint, string busNo, float pickUpDistance) : base(name, session, isDayScholar, EntryTestMarks, HSMarks)
        {
            this.pickUpPoint = pickUpPoint;
            BusNo = busNo;
            this.pickUpDistance = pickUpDistance;
        }

        public string getPickUpPoint()
        {
            return pickUpPoint;
        }
        public string getBusNo()
        {
            return BusNo;
        }
        public float getPickUpDistance()
        {
            return pickUpDistance;
        }

        public void setPickUpPoint(string pickUpPoint)
        {
            this.pickUpPoint = pickUpPoint;
        }
        public void setBusNo(string BusNo)
        {
            this.BusNo = BusNo;
        }
        public void setPickUpDistance(float pickUpDistance)
        {
            this.pickUpDistance = pickUpDistance;
        }

        public float getBusFee()
        {
            float fee = 0;
            fee = 10 * pickUpDistance;
            return fee;
        }
    }
}
