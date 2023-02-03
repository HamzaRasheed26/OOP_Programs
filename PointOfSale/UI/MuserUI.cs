using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointOfSale.BL;
using PointOfSale.DL;

namespace PointOfSale.UI
{
    internal class MuserUI
    {
        public static MUser SignUp()
        {
            string password, username, role;

            Console.Clear();

            Console.WriteLine("Enter your Name : ");
            username = Console.ReadLine();
            Console.WriteLine("Enter Pasword : ");
            password = Console.ReadLine();

            role = "Customer";

            MUser temp = new MUser(username, password, role);

            return temp;
        }

        public static string signin()
        {
            string password, username;

            Console.Clear();
            PosUI.head();
            Console.Write("Enter UserName : ");
            username = Console.ReadLine();
            Console.Write("Enter Password : ");
            password = Console.ReadLine();

            foreach (MUser user in MUserDL.UsersList)
            {
                if (user.getUsername() == username && user.getPassword() == password)
                {
                    if(user.getRole() == "Customer")
                    {
                        CustomerDL.initializeCustomer(username);
                    }

                    return user.getRole();
                }
            }

            return null;
        }

        public static char LoginPage()
        {
            Console.Clear();
            PosUI.head();
            char option;
            Console.WriteLine(" Login Page >>");
            Console.WriteLine(" 1. Sign In");
            Console.WriteLine(" 2. Sign Up");
            Console.WriteLine(" 3. Exit");
            Console.WriteLine("Your Option : ");
            option = char.Parse(Console.ReadLine());
            return option;
        }


    }
}
