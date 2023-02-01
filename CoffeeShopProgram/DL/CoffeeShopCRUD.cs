using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CoffeeShopProgram.BL;
using CoffeeShopProgram.DL;
using CoffeeShopProgram.UI;

namespace CoffeeShopProgram.DL
{
    internal class CoffeeShopCRUD
    {
        public static CoffeeShop shop = new CoffeeShop(" Blue Sky");

        public static void AddItemToListOfShop(MenuItem Item)
        {
            shop.addMenuItem(Item);
        }

        public static bool AddOrderToListOfShop(string ItemName)
        {
            return shop.addOrder(ItemName);
        }

        public static void fullFillOrder()
        {
            CoffeeShopUI.menuLines("FullFill ORDER");

            List<string> orders = shop.getOrders();
            if (orders != null)
            {
                foreach (string item in orders)
                {
                    Console.WriteLine(" The " + item + " is ready!");
                }
            }
            Console.WriteLine(" All orders have been fulfiled");

            shop.makeOrderListNull();
        }

        public static string readShopName(string path)
        {
            string record = "";
            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);               
                record = file.ReadLine();

                file.Close();
            }
            return record;
        }

        public static List<MenuItem>  readMenuItems(string path)
        {
            List<MenuItem> menuList = new List<MenuItem>();

            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;

                while((record = file.ReadLine()) != null)
                {
                    string[] splittedRecord = record.Split(',');

                    string name = splittedRecord[0];
                    string type = splittedRecord[1];
                    int price = int.Parse(splittedRecord[2]);

                    MenuItem newMenu = new MenuItem(name, type, price);
                    menuList.Add(newMenu);
                }
                file.Close();
            }
            return menuList;
        }

        public static List<string> readOrders(string path)
        {
            List<string> orders = new List<string>();
            if(File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string record;
               
                while((record = file.ReadLine()) != null)
                {
                    orders.Add(record);
                }
                file.Close();
            }
            return orders;
        }

        public static void LoadData(string shopNameFilePath, string menuItemFilePath, string ordersFilePath)
        {
            string shopName;
            shopName = readShopName(shopNameFilePath);
            List<MenuItem> menuList;
            menuList = readMenuItems(menuItemFilePath);
            List<string> orders;
            orders = readOrders(ordersFilePath);

            shop = new CoffeeShop(shopName, menuList, orders);
        }

        public static void storeData(string shopNameFilePath, string menuItemFilePath, string ordersFilePath)
        {
            StreamWriter file = new StreamWriter(shopNameFilePath);
            string shopName = shop.getShopName();
            file.WriteLine(shop);
            file.Flush();
            file.Close();

            StreamWriter menuFile = new StreamWriter(menuItemFilePath);
            List<MenuItem> menuList = shop.getMenuList();
            if(menuList != null)
            {
                foreach (MenuItem menu in menuList)
                {
                    string name = menu.getItemName();
                    string type = menu.getType();
                    int price = menu.getPrice();

                    menuFile.WriteLine(name + "," + type + "," + price);
                }
            }
            menuFile.Flush();
            menuFile.Close();

            StreamWriter orderFile = new StreamWriter(ordersFilePath);
            List<string> orders = shop.getOrders();
            if(orders != null)
            {
                foreach(string od in orders)
                {
                    orderFile.WriteLine(od);
                }
            }
            orderFile.Flush();
            orderFile.Close();
         }

    }
}
