using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.BL
{
    internal class Customer
    {
        // Constructors
        public Customer(string name, string address, string contact)
        {
            CustomerName = name;
            CustomerAddress = address;
            CustomerContact = contact;
        }
        // Data Members
        public string CustomerName;
        public string CustomerAddress;
        public string CustomerContact;
        public List<Product> products = new List<Product>();

        // MEmber Function
        public void AddProduct(Product P)
        {
            products.Add(P);
        }
        public List<Product> getAllProducts()
        {
            return products;
        }

        public float getTotalTax()
        {
            float total = 0;
            foreach(Product product in products)
            {
                product.calculateTax();
                total = total + product.tax;
            }
            return total;
        }

    }
}
