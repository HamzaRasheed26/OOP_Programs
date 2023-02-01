using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopProgram.BL
{
    class MenuItem
    {
        private string name;
        private string type;
        private int price;

        // Constructor
        public MenuItem(string name, string type, int price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public string getItemName()
        {
            return name;
        }
        public string getType()
        {
            return type;
        }
        public int getPrice()
        {
            return price;
        }
        public bool setPrice(int price)
        {
            if(price >= 0)
            {
                this.price = price;
                return true;
            }
            return false;
        }

    }
}
