using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopProgram.BL;
using CoffeeShopProgram.DL;

namespace CoffeeShopProgram.UI
{
    internal class CoffeeShopUI
    {
        public static void head()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("*        COFFEE SHOP         *");
            Console.WriteLine("******************************");
            Console.WriteLine("");
        }

        public static char Menu()
        {
            char op;
            Console.Clear();
            head();
            Console.WriteLine(" WEILCOME TO " + CoffeeShopCRUD.shop.getShopName() + " Coffee Shop ");
            Console.WriteLine(" MENU >> ");
            Console.WriteLine(" 1. Add a Menu Item ");
            Console.WriteLine(" 2. View the Cheapest Item In the menu");
            Console.WriteLine(" 3. View the Drink's Menu");
            Console.WriteLine(" 4. View the Food's Menu");
            Console.WriteLine(" 5. Add Order");
            Console.WriteLine(" 6. Fullfill Order");
            Console.WriteLine(" 7. View the Order's List");
            Console.WriteLine(" 8. Total Payable Amount");
            Console.WriteLine(" 9. Exit");
            Console.Write("\n Your Option...: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }

        public static void AddMenuItem()
        {
            menuLines("ADD MENU ITEM");

            Console.Write(" How many Items You want to enter.. ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                CoffeeShopCRUD.AddItemToListOfShop(takeInputMenuItem());
            }
        }

        public static MenuItem takeInputMenuItem()
        {
            string name, type;
            int price;
            Console.Write("\n Enter the item name : ");
            name = Console.ReadLine();
            Console.Write(" Enter the item type (Food / Drink) : ");
            type = Console.ReadLine();
            Console.Write(" Enter the item price : ");
            price = int.Parse(Console.ReadLine());

            return new MenuItem(name, type, price);
        }


        public static void press()
        {
            Console.Write(" Press any  key to continue....");
            Console.ReadKey();
        }

        public static void menuLines(string title)
        {
            Console.Clear();
            head();
            Console.WriteLine(" " + title + " >> ");
        }

        public static void AddOrder()
        {
            menuLines("ADD ORDER");

            Console.Write(" How many Orders You want to add.. ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write(" Enter the product name :");
                string ItemName = Console.ReadLine();
                if (!CoffeeShopCRUD.AddOrderToListOfShop(ItemName))
                {
                    Console.WriteLine(" This Item is Currently unavailable!");
                }
            }

        }

        public static void viewCheapestitem()
        {
            menuLines("CHEAPEST ITEM");

            string item = CoffeeShopCRUD.shop.cheapestItem();

            Console.WriteLine(" The cheapest Item Available is : " + item);
        }

        public static void viewAllDrinks()
        {
            menuLines("DRINKS ITEMS");

            List<string> drinks = CoffeeShopCRUD.shop.drinksOnly();


            Console.WriteLine(" Drinks Items Name");
            if (drinks != null)
            {
                int i = 1;
                foreach (string item in drinks)
                {
                    Console.WriteLine(" " + i + ". " + item);
                    i++;
                }
            }
            else
            {
                Console.WriteLine(" No Drinks Available!");
            }
        }

        public static void viewAllFood()
        {
            menuLines("Food ITEMS");

            List<string> Food = CoffeeShopCRUD.shop.foodOnly();


            Console.WriteLine(" Food Items Name");
            if (Food != null)
            {
                int i = 1;
                foreach (string item in Food)
                {
                    Console.WriteLine(" " + i + ". " + item);
                    i++;
                }
            }
            else
            {
                Console.WriteLine(" No Food Available!");
            }
        }

        public static void viewOrdersList()
        {
            menuLines("ALL ORDERS");

            List<string> items = CoffeeShopCRUD.shop.getOrders();

            if (items != null)
            {
                Console.WriteLine(" Order Products Name");
                int i = 1;
                foreach (string item in items)
                {
                    Console.WriteLine(" " + i + ". " + item);
                    i++;
                }
            }
            else
            {
                Console.WriteLine(" All orders have been fulfiled");
            }
        }

        public static void TotalPayableAmount()
        {
            menuLines("DUE AMOUNT");

            double price = CoffeeShopCRUD.shop.dueAmount();

            Console.WriteLine(" TOTAL DUE AMOUNT IS : " + price + " Rs");
        }
    }
}
