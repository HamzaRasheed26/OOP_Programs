using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    internal class ProductUI
    {
        public static Product takeProductInput()
        {
            string name, category;
            float price;
            int stock, theshold;

            Console.WriteLine(" Enter the Product name : ");
            name = Console.ReadLine();
            Console.WriteLine(" Enter the product category : ");
            category = Console.ReadLine();
            Console.WriteLine(" Enter the product price : ");
            price = float.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the stock : ");
            stock = int.Parse(Console.ReadLine());
            Console.WriteLine(" Enter the theshold ");
            theshold = int.Parse(Console.ReadLine());

            Product newProduct = new Product(name, category, price, stock, theshold);

            return newProduct;
        }



        public static void viewAllProducts()
        {
            if (ProductDL.productList != null)
            {
                Console.WriteLine("Product\tCategory\tPrice\tStock");
                foreach (Product p in ProductDL.productList)
                {
                    string name = p.getName();
                    string category = p.getCategory();
                    float price = p.getPrice();
                    int stock = p.getStock();

                    Console.WriteLine(name + "\t" + category + "\t" + price + "\t" + stock);
                }
            }
            else
            {
                Console.WriteLine(" NO PRODUCT EXIST !");
            }
        }



        public static void ShowByHighestPrice(List<Product> sortedProductList)
        {
            if (sortedProductList != null)
            {
                Console.WriteLine("Product\tCategory\tPrice\tStock");

                string name = sortedProductList[0].getName();
                string category = sortedProductList[0].getCategory();
                double price = sortedProductList[0].getPrice();
                int stock = sortedProductList[0].getStock();

                Console.WriteLine(name + "\t" + category + "\t" + price + "\t" + stock);

            }
            else
            {
                Console.WriteLine(" NO PRODUCT EXIST !");
            }
        }

        public static void ViewSalesTaxOfProducts()
        {
            if (ProductDL.productList != null)
            {
                Console.WriteLine("Product\tSale Tax ");
                foreach (Product p in ProductDL.productList)
                {
                    string name = p.getName();
                    float tax = p.calculateTax();

                    Console.WriteLine(name + "\t" + tax);

                }
            }
            else
            {
                Console.WriteLine(" NO PRODUCT EXIST !");
            }
        }



        public static void fullfillOrder(List<Product> newProductList)
        {
            if (newProductList != null)
            {
                Console.WriteLine("ID Product\tCategory");
                int i = 0;
                foreach (Product p in newProductList)
                {
                    string name = p.getName();
                    string category = p.getCategory();
                    i++;
                    Console.WriteLine(i + ". " + name + "\t" + category);
                }

                while (true)
                {
                    Console.Write(" Enter the Product ID you want to increase stock :");
                    int id = int.Parse(Console.ReadLine());
                    id--;
                    while (true)
                    {
                        Console.Write(" Enter the Amount of stock you want to increase : ");
                        int stock = int.Parse(Console.ReadLine());

                        if (newProductList[id].setStock(stock))
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Invalid Stock Value !");
                        }
                    }
                    Console.Write(" Want to fullfill another product stock (y/n) ");
                    char flag = char.Parse(Console.ReadLine());

                    if (flag == 'n' || flag == 'N')
                    {
                        break;
                    }
                }
            }
        }
    }
}
