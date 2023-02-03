using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;
using PointOfSale.DL;
using PointOfSale.UI;

namespace PointOfSale.DL
{
    internal class CustomerDL
    {
        public static List<Customer> CustomerList = new List<Customer>();

        public static Customer presentCustomer;

        public static void initializeCustomer(string name)
        {
            presentCustomer = new Customer(name);
        }

        public static void addIntoCustomerList(Customer c)
        {
            CustomerList.Add(c);
        }

        public static int isProductBuyed(Product temp)
        {
            if (temp != null)
            {
                int value = temp.getStock();
                value--;
                if (temp.setStock(value))
                {
                    CustomerDL.presentCustomer.addProduct(temp);
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            return 0;
        }

        public static float calculateTotalSaleTax()
        {
            float tax = 0;
            if( presentCustomer != null)
            {
                List<Product> tempList = presentCustomer.getProductList();

                if (tempList != null)
                {
                    foreach (Product p in tempList)
                    {
                        tax = tax + p.calculateTax();
                    }
                }
            }
            return tax;
        }

        public static float priceofAllProduct()
        {
            float total = 0;
            if (presentCustomer != null)
            {
                List<Product> tempList = presentCustomer.getProductList();

                if (tempList != null)
                {
                    foreach (Product p in tempList)
                    {
                        total = total + p.getPrice();
                    }
                }
            }
            return total;
        }

        public static int customerProductCount()
        {
            return presentCustomer.buyedProductCount();
        }

        public static bool readData(string path)
        {

            if (File.Exists(path))
            {
                StreamReader file = new StreamReader(path);
                string line;


                while ((line = file.ReadLine()) != null)
                {
                    string[] splittedRecord = line.Split(',');

                    string name = splittedRecord[0];

                    string[] splittedProduct = splittedRecord[1].Split(';');

                    Customer newCustomer = new Customer(name);

                    foreach(string pName in splittedProduct)
                    {
                        Product p = ProductDL.isProductExist(pName);
                        if(p != null)
                        {
                            newCustomer.addProduct(p);
                        }
                    }

                    addIntoCustomerList(newCustomer);

                }
                file.Close();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void combineData()
        {
            if(presentCustomer != null)
            {
                string name = presentCustomer.getCustomerName();

                foreach (Customer c in CustomerList)
                {

                    if (name == c.getCustomerName())
                    {
                        c.setProductList(presentCustomer.getProductList());
                    }
                }
            }
        }

        public static void storeData(string path)
        {
            StreamWriter file = new StreamWriter(path);
            foreach (Customer c in CustomerList)
            {
                

                string productNames = "";
                string name = c.getCustomerName();
                List<Product> pList = c.getProductList();
                if (pList.Count != 0)
                {
                    for (int idx = 0; idx < pList.Count - 1; idx++)
                    {
                        productNames = productNames + pList[idx].getName() + ";";
                    }
                    productNames = productNames + pList[pList.Count - 1].getName();
                }
                file.WriteLine(name + "," + productNames);
                
            }
            file.Flush();
            file.Close();
        }

    }
}
