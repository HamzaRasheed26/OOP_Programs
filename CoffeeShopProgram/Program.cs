using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopProgram.BL;
using CoffeeShopProgram.DL;
using CoffeeShopProgram.UI;

namespace CoffeeShopProgram
{
    class Program
    {

        static void Main(string[] args)
        {
            string shopNameFilePath = "shopNameFile.txt";
            string menuItemFilePath = "menuItemsFile.txt";
            string ordersFilePath = "ordersFile.txt";

            CoffeeShopCRUD.LoadData(shopNameFilePath, menuItemFilePath, ordersFilePath);

            char op;

            while(true)
            {
                op = CoffeeShopUI.Menu();

                if( op == '1')
                {
                    CoffeeShopUI.AddMenuItem();
                }
                else if( op == '2')
                {
                    CoffeeShopUI.viewCheapestitem();
                }
                else if (op == '3')
                {
                    CoffeeShopUI.viewAllDrinks();
                }
                else if (op == '4')
                {
                    CoffeeShopUI.viewAllFood();
                }
                else if (op == '5')
                {
                    CoffeeShopUI.AddOrder();
                }
                else if (op == '6')
                {
                    CoffeeShopCRUD.fullFillOrder();
                }
                else if (op == '7')
                {
                    CoffeeShopUI.viewOrdersList();
                }
                else if (op == '8')
                {
                    CoffeeShopUI.TotalPayableAmount();
                }
                else if (op == '9')
                {
                    CoffeeShopCRUD.storeData(shopNameFilePath, menuItemFilePath, ordersFilePath);
                    break;
                }

                CoffeeShopUI.press();
            }
        } 
    }
}
