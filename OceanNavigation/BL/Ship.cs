using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OceanNavigation.BL
{
    internal class Ship
    {
        private string serialNumber;
        private Angle latitude;
        private Angle longitude;

        // constructur
        public Ship(string serialNumber, Angle latitude, Angle longitude)
        {
            this.serialNumber = serialNumber;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        public string getSerialNumber()
        {
            return serialNumber;
        }
        public Angle getLatitude()
        {
            return latitude;
        }
        public Angle getLongitude()
        {
            return longitude;
        }

        public void setSerialNumber(string serialNumber)
        {
            this.serialNumber = serialNumber;
        }
        public void setLatitude(Angle latitude)
        {
            this.latitude = latitude;
        }
        public void setLongitude(Angle longitude)
        {
            this.longitude = longitude;
        }

        public bool isMatch(Angle lat, Angle longit)
        {
            if(  latitude.isSame(lat) && longitude.isSame(longit))
            {
                return true;
            }
            return false;
        }

        public void changePosition(Angle latitude, Angle longitude)
        {
            this.latitude = latitude;
            this.longitude = longitude;
        }
    }
}
