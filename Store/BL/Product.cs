using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL
{
    internal class Product
    {
        // Constructors
        public Product(string Name, string Category, int price)
        {
            this.Name = Name;
            this.Category = Category;
            this.price = price;
        }
        // Data Members
        public string Name;
        public string Category;
        public int price;
        public float tax;

        // Member Function 
        public void calculateTax()
        {
            if(Category == "Grocery" || Category == "grocery")
            {
                tax = 0.10F;
            }
            else if ( Category == "Sport" || Category == "sport")
            {
                tax = 0.15F;
            }
            else
            {
                tax = 0.5F;
            }

        }
    }
}
