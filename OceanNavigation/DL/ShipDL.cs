using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using OceanNavigation.BL;
using OceanNavigation.UI;

namespace OceanNavigation.DL
{
    internal class ShipDL
    {
        public static List<Ship> shipList = new List<Ship>();

        public static void AddShipInList(Ship newShip)
        {
            shipList.Add(newShip);
        }

        public static bool findShip(string serial)
        {
            foreach (Ship S in shipList)
            {
                string serialNumber = S.getSerialNumber();
                if (serial == serialNumber)
                {

                    ShipUI.printLocation(S);
                    return true;
                }
            }
            return false;
        }

        public static void LoadData(string path)
        {
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
                while ((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                    string serialNumber = splittedRecord[0];

                    int degrees = int.Parse(splittedRecord[1]);
                    float minutes = float.Parse(splittedRecord[2]);
                    char direction = char.Parse(splittedRecord[3]);
                    Angle latitude = new Angle(degrees, minutes, direction);

                    degrees = int.Parse(splittedRecord[4]);
                    minutes = float.Parse(splittedRecord[5]);
                    direction = char.Parse(splittedRecord[6]);
                    Angle longitude = new Angle(degrees, minutes, direction);

                    Ship newShip = new Ship(serialNumber, latitude, longitude);

                    AddShipInList(newShip);
                }
                file.Close();
            }
        }

        public static void StoreData(string path)
        {
            StreamWriter file = new StreamWriter(path);

            foreach(Ship s in shipList)
            {
                string serial = s.getSerialNumber();
                Angle latitude = s.getLatitude();
                Angle longitude = s.getLongitude();

                int latDegree = latitude.getDegrees();
                float latMinute = latitude.getMinutes();
                char latdir = latitude.getDirection();

                int longDegree = longitude.getDegrees();
                float longMinute = longitude.getMinutes();
                char longdir = longitude.getDirection();

                file.WriteLine(serial + "," + latDegree + "," + latMinute + "," + latdir + "," + longDegree + "," + longMinute + "," + longdir);
            }
            file.Flush();
            file.Close();
        }
    }
}
