using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.BL
{
    internal class Customer
    {
        private string customerName;

        private List<Product> purchased;

        public Customer(string customerName)
        {
            this.customerName = customerName;
            purchased = new List<Product>();
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public List<Product> getProductList()
        {
            if (purchased != null)
            {
                return purchased;
            }
            return null;
        }

        public void setProductList(List<Product> purchased)
        {
            this.purchased = purchased;
        }

        public void addProduct( Product buyed)
        {
            purchased.Add(buyed);
        }

        public int buyedProductCount()
        {
            return purchased.Count;
        }

    }
}
