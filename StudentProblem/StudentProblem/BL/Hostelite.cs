using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProblem.BL
{
    internal class Hostelite : Student
    {
        private int RoomNumber;
        private bool isFridgeAvailable;
        private bool isInternetAvaialble;

        public Hostelite(string name, string session, bool isDayScholar, float EntryTestMarks, float HSMarks, int RoomNumber, bool isFridgeAvailable, bool isInternetAvaialble) : base(name, session, isDayScholar, EntryTestMarks, HSMarks)
        {
            this.RoomNumber = RoomNumber;
            this.isFridgeAvailable = isFridgeAvailable;
            this.isInternetAvaialble = isInternetAvaialble;
        }

        public int getRoomNumber()
        {
            return RoomNumber;
        }
        public bool getFridge()
        {
            return isFridgeAvailable;
        }
        public bool getInternet()
        {
            return isInternetAvaialble;
        }

        public void setRoomNumber(int RoomNumber)
        {
            this.RoomNumber = RoomNumber;
        }
        public void setFridge(bool available)
        {
            isFridgeAvailable = available;
        }
        public void setInternet(bool available)
        {
            isInternetAvaialble = available;
        }

        public float getHostelFee()
        {
            float fee = 0;
            fee = 10000;
            if(isFridgeAvailable)
            {
                fee = fee + 1000;
            }
            if(isInternetAvaialble)
            {
                fee = fee + 1000; 
            }
            return fee;
        }
    }
}
