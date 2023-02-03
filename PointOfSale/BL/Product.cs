using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    internal class Product
    {
        private string name;
        private string category;
        private float price;
        private int stock;
        private int thershold;

        public Product(string name, string category, float price, int stock, int thershold)
        {
            this.name = name;
            this.category = category;
            this.price = price;
            this.stock = stock;
            this.thershold = thershold;
        }

        public string getName()
        {
            return name;
        }
        public string getCategory()
        {
            return category;
        }
        public float getPrice()
        {
            return price;
        }
        public int getStock()
        {
            return stock;
        }
        public int getThershold()
        {
            return thershold;
        }

        public bool setStock(int stock)
        {
            if( stock >= 0 && stock <= 100 )
            {
                this.stock = stock;
                return true;
            }
            return false;
        }

        public float calculateTax()
        {
            float tax;
            if(category == "Grocery")
            {
                tax = price * 10 / 100F;
            }
            else if(category == "Fruit")
            {
                tax = price * 5 / 100F;
            }
            else
            {
                tax = price * 15 / 100F;
            }
            return tax;
        }

        public bool isStockMinimun()
        {
            if(stock <= thershold)
            {
                return true;
            }
            return false;
        }

    }
}
