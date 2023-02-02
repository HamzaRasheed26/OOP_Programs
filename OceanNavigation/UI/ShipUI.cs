using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;

namespace OceanNavigation.UI
{
    internal class ShipUI
    {
        public static void head()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("*      OCEAN NAVIGATION       *");
            Console.WriteLine("*******************************");
        }
        public static string Menu()
        {
            Console.Clear();
            head();
            string op = "";

            Console.WriteLine(" 1. Add Ship");
            Console.WriteLine(" 2. View Ship Position");
            Console.WriteLine(" 3. View Ship Serial Number");
            Console.WriteLine(" 4. Change Ship Position");
            Console.WriteLine(" 5. Exit");
            Console.Write(" Your option ....");
            op = Console.ReadLine();

            return op;
        }



        public static Ship AddShip()
        {
            Console.Clear();
            head();

            string serial;

            Console.Write(" Enter the Ship Serial Number : ");
            serial = Console.ReadLine();

            Console.WriteLine(" *** Latitude of Ship ***");
            Angle latitude = inputAngle();

            Console.WriteLine(" *** longitude of Ship ***");
            Angle longitude = inputAngle();

            Console.Write(" Press any key to continue ...");
            Console.ReadKey();

            Ship newShip = new Ship(serial, latitude, longitude);

            return newShip;
        }

        public static Angle inputAngle()
        {
            int degree;
            float min;
            char direction;

            Console.Write(" Enter Degree : ");
            degree = int.Parse(Console.ReadLine());

            Console.Write(" Enter Minutes : ");
            min = float.Parse(Console.ReadLine());

            Console.Write(" Enter Direction : ");
            direction = char.Parse(Console.ReadLine());

            Angle temp = new Angle(degree, min, direction);

            return temp;
        }



        public static void ShipPosition()
        {
            Console.Clear();
            head();

            Console.WriteLine(" View Ship Position >> \n");

            Console.Write(" Enter Ship Serial Number : ");
            string serial = Console.ReadLine();

            if (!ShipDL.findShip(serial))
            {
                Console.WriteLine(" No Ship Found !");
            }

            Console.Write(" Press any key to continue ...");
            Console.ReadKey();
        }

        public static void viewShipSerialNumber()
        {
            Console.Clear();
            head();

            Console.WriteLine(" VIEW SHIP SERIAL NUMBER >> ");

            Console.WriteLine(" *** Enter Latitude of Ship ***");
            Angle latitude = inputAngle();

            Console.WriteLine(" ***  longitude of Ship ***");
            Angle longitude = inputAngle();

            int a = 0;

            foreach (Ship s in ShipDL.shipList)
            {
                if (s.isMatch(latitude, longitude))
                {
                    string serial = s.getSerialNumber();
                    a = 1;
                    Console.WriteLine(" Ship Serial no. is : " + serial);
                    break;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(" No Ship Found !");
            }

            Console.Write(" Press any key to continue ...");
            Console.ReadKey();
        }

        public static void changeShipPosition()
        {
            Console.Clear();
            head();
            Console.WriteLine(" CHANGE SHIP POSITION >> ");

            Console.Write(" Enter Ship Serial Number : ");
            string serial = Console.ReadLine();

            int a = 0;
            foreach (Ship S in ShipDL.shipList)
            {
                string serialNumber = S.getSerialNumber();
                if (serial == serialNumber)
                {
                    a = 1;
                    Console.WriteLine(" *** Enter Latitude of Ship ***");
                    Angle latitude = inputAngle();

                    Console.WriteLine(" ***  longitude of Ship ***");
                    Angle longitude = inputAngle();

                    S.changePosition(latitude, longitude);
                    break;
                }
            }

            if (a == 0)
            {
                Console.WriteLine(" No Ship Found !");
            }

            Console.Write(" Press any key to continue ...");
            Console.ReadKey();

        }

        public static void print(Angle print)
        {
            int degrees = print.getDegrees();
            float minutes = print.getMinutes();
            char direction = print.getDirection();

            Console.Write("{0}\u00b0 {1}' {2}", degrees, minutes, direction);
        }

        public static void printLocation(Ship temp)
        {
            Console.Write(" Ship is  ");
            Angle latitude = temp.getLatitude();
            Angle longitude = temp.getLongitude();
            print(latitude);
            Console.Write(" and ");
            print(longitude);
            Console.WriteLine();
        }
    }
}
