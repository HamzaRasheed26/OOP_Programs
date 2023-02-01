using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopProgram.BL
{
    class CoffeeShop
    {
        private string name;
        private List<MenuItem> menu;
        private List<string> orders;

        // Constructur
        public CoffeeShop(string name)
        {
            this.name = name;
            menu = new List<MenuItem>();
            orders = new List<string>();
        }

        public CoffeeShop(string name, List<MenuItem> menu, List<string> orders)
        {
            this.name = name;
            this.menu = menu;
            this.orders = orders;
        }

        // member function

        public string getShopName()
        {
            return name;
        }
        public List<MenuItem> getMenuList()
        {
            if (menu != null)
            {
                return menu;
            }
            return null;
        }

        public void addMenuItem(MenuItem menu)
        {
            this.menu.Add(menu);
        }

        public bool isItemExist(string name)
        {
            foreach(MenuItem M in menu)
            {
                if( M.getItemName() == name)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addOrder(string ItemName)
        {
            if(isItemExist(ItemName))
            {
                orders.Add(ItemName);
                return true;
            }
            return false;
        }

        public void makeOrderListNull()
        {
            orders = null;
        }

        public List<string> getOrders()
        {
            if (orders != null)
            {
                return orders;
            }

            return null;
        }

        public double dueAmount()
        {
            double price = 0;
            if( orders != null)
            {
                foreach (string item in orders)
                {
                    foreach (MenuItem m in menu)
                    {
                        if (m.getItemName() == item)
                        {
                            price = price + m.getPrice();
                        }
                    }
                }
            }
            return price;
        }

        public string cheapestItem()
        {
            if(menu != null)
            {
                string cheapestItem = menu[0].getItemName();
                float price = menu[0].getPrice();
                foreach (MenuItem m in menu)
                {
                    if (price > m.getPrice())
                    {
                        price = m.getPrice();
                        cheapestItem = m.getItemName();
                    }
                }
                return cheapestItem;
            }
            return null;
        }

        public List<string> drinksOnly()
        {
            List<string> drinks = new List<string>();
            foreach(MenuItem m in menu)
            {
                if(m.getType() == "drink" || m.getType() == "Drink")
                {
                    drinks.Add(m.getItemName());
                }
            }
            return drinks;
        }

        public List<string> foodOnly()
        {
            List<string> food = new List<string>();
            foreach (MenuItem m in menu)
            {
                if (m.getType() == "food" || m.getType() == "Food")
                {
                    food.Add(m.getItemName());
                }
            }
            return food;
        }
    }
}
