using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    internal class CustomerUI
    {
        public static string inputProductName()
        {
            Console.Write(" Enter the Product name you want to buy : ");
            string name = Console.ReadLine();
            return name;
        }

        public static void buyProduct(int flag, Product p)
        {
            if (flag == 1)
            {
                string name = p.getName();
                float price = p.getPrice();
                Console.WriteLine(" Product : " + name + " of Price : " + price + " is Buyed Succssfully :) ");
            }
            else if (flag == 2)
            {
                string name = p.getName();
                Console.WriteLine(" Product : " + name + " is out of stock ");
            }
            else if (flag == 0)
            {
                Console.WriteLine(" This Product is not available ");
            }
        }

        public static void generateInvoice()
        {
            float totalPrice = CustomerDL.priceofAllProduct();
            float tax = CustomerDL.calculateTotalSaleTax();
            int count = CustomerDL.customerProductCount();

            Console.WriteLine(" Total Products Buyed : " + count);
            Console.WriteLine(" Price of all Products : " + totalPrice);
            Console.WriteLine(" Sale Tax : " + tax);

            float finalPrice = totalPrice + tax;

            Console.WriteLine(" Final Price is : " + finalPrice);
        }
    }
}
