using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;

namespace PointOfSale.DL
{
    internal class ProductDL
    {
        public static List<Product> productList = new List<Product>();

        public static void addProductInList(Product newProduct)
        {
            productList.Add(newProduct);
        }

        public static List<Product> sortProductListHighest()
        {
            if (productList != null)
            {
                List<Product> sortedProductList = productList.OrderByDescending(o => o.getPrice()).ToList();
                return sortedProductList;
            }

            return null;
        }

        public static Product isProductExist(string productName)
        {
            if(productList != null)
            {
                foreach(Product product in productList)
                {
                    if(product.getName() == productName)
                    {
                        return product;
                    }
                }
            }
            return null;
        }

        public static List<Product> makeOrderProductList()
        {
            int flag = 0;
            List<Product> newProductList = new List<Product>();
            foreach (Product p in productList)
            {
                if (p.isStockMinimun())
                {
                    flag = 1;
                    newProductList.Add(p);
                }
            }
            if (flag == 1)
            {
                return newProductList;
            }
            else
            {
                return null;
            }
        }

        public static void readData(string path)
        {

            if (File.Exists(path))
            {
                string line;
                StreamReader file = new StreamReader(path);

                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    string name = splittedRecord[0];
                    string category = splittedRecord[1];
                    float price = float.Parse(splittedRecord[2]);
                    int stock = int.Parse(splittedRecord[3]);
                    int thershold = int.Parse(splittedRecord[4]);

                    Product readedProduct = new Product(name, category, price, stock, thershold);

                    addProductInList(readedProduct);

                }
                file.Close();
            }
        }

        public static void storeData(string path)
        {

            StreamWriter file = new StreamWriter(path);
            int i = 0;
            foreach (Product p in productList)
            {
                string name = p.getName();
                string category = p.getCategory();
                float price = p.getPrice();
                int stock = p.getStock();
                int thershold = p.getThershold();

                i++;
                file.Write(name + "," + category + "," + price + "," + stock + "," + thershold);
                if (i < productList.Count)
                {
                    file.WriteLine();
                }
            }

            file.Flush();
            file.Close();

        }

    }
}
