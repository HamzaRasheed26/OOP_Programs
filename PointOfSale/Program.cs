using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using PointOfSale.BL;
using PointOfSale.DL;
using PointOfSale.UI;

namespace PointOfSale
{
    internal class Program
    {

        

        static void Main(string[] args)
        {
            string credentialFilePath = "Credentials.txt";
            
            string productFilePath = "ProductsFile.txt";
            string customerFilePath = "CustomersFile.txt";

            MUserDL.readData(credentialFilePath);
            ProductDL.readData(productFilePath);
            CustomerDL.readData(customerFilePath);

            string role;

            char op;
            while (true)
            {
                
                op = MuserUI.LoginPage();

                if (op == '1')
                {
                    // sign in
                    role = MuserUI.signin();



                    if (role == "Admin")
                    {
                        while (true)
                        {
                            char option = PosUI.AdminMenu();

                            if (option == '1')
                            {
                                Product newProduct;
                                newProduct = ProductUI.takeProductInput();
                                ProductDL.addProductInList(newProduct);
                                
                            }
                            else if (option == '2')
                            {
                                ProductUI.viewAllProducts();
                            }
                            else if (option == '3')
                            {
                                List<Product> sortedProductList;
                                sortedProductList = ProductDL.sortProductListHighest();
                                ProductUI.ShowByHighestPrice(sortedProductList);
                            }
                            else if (option == '4')
                            {
                                ProductUI.ViewSalesTaxOfProducts();
                            }
                            else if (option == '5')
                            {
                                List<Product> newProductList;
                                newProductList = ProductDL.makeOrderProductList();
                                ProductUI.fullfillOrder(newProductList);
                            }
                            else if (option == '6')
                            {
                                
                                break;
                            }
                            PosUI.button();
                        }
                    }
                    else if( role == "Customer")
                    {
                        while(true)
                        {
                            char option = PosUI.CustomerMenu();

                            if(option == '1')
                            {
                                ProductUI.viewAllProducts();
                            }
                            else if(option == '2')
                            {
                                string name;
                                name = CustomerUI.inputProductName();
                                Product temp = ProductDL.isProductExist(name);
                                int flag;
                                flag = CustomerDL.isProductBuyed( temp);
                                CustomerUI.buyProduct(flag, temp);
                            }
                            else if (option == '3')
                            {
                                CustomerUI.generateInvoice();
                            }
                            else if(option == '4')
                            {
                                break;
                            }
                            PosUI.button();
                        }
                        
                    }

                    ProductDL.storeData(productFilePath);
                    CustomerDL.combineData();
                    CustomerDL.storeData(customerFilePath);

                }
                else if (op == '2')
                {
                    // sign up
                    MUser user = MuserUI.SignUp();
                    if(!MUserDL.isExist(user))
                    {
                        MUserDL.AddUserIntoList(user);
                        
                        if(user.getRole() == "Customer")
                        {
                            string username = user.getUsername();
                            Customer newCustomer = new Customer(username);
                            CustomerDL.addIntoCustomerList(newCustomer);
                            CustomerDL.storeData(customerFilePath);
                        }

                    }
                    
                    MUserDL.storeData(credentialFilePath);
                }
                else if (op == '3')
                {
                    // exit
                    break;
                }
            }
        }
        
    }
}
