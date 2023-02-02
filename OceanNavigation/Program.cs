using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OceanNavigation.BL;
using OceanNavigation.DL;
using OceanNavigation.UI;

namespace OceanNavigation
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            string path = "ShipsData.txt";
            ShipDL.LoadData(path);

            string op;
            while(true)
            {
                op = ShipUI.Menu();

                if(op == "1")
                {
                    Ship temp = ShipUI.AddShip();
                    ShipDL.AddShipInList(temp);
                }
                else if(op == "2")
                {
                    ShipUI.ShipPosition();
                }
                else if(op == "3")
                {
                    ShipUI.viewShipSerialNumber();
                }
                else if(op == "4")
                {
                    ShipUI.changeShipPosition();
                }
                else if(op == "5")
                {
                    ShipDL.StoreData( path);
                    break;
                }
            }
        }

        
    }
}
