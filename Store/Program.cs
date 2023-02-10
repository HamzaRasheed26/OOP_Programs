using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Store.BL;

namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Customer C1 = new Customer("Hamza", "305-B", "0309-5426793");

            Product p1 = new Product("Sugar", "Grocery", 200);
            Product p2 = new Product("Bat", "Sport", 1000);
            Product p3 = new Product("Apple", "Fruit", 200);

            C1.AddProduct(p1);
            C1.AddProduct(p2);
            C1.AddProduct(p3);

            Console.WriteLine(" Total Tax: " + C1.getTotalTax());

            List<Product> TP = C1.getAllProducts();

            foreach (Product p in TP)
            {
                Console.WriteLine(p.Name);
            }

            Console.ReadKey();
        }
    }
}
