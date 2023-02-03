using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.UI
{
    internal class PosUI
    {
        public static void head()
        {
            Console.WriteLine("***************************");
            Console.WriteLine("*   Departmental Store    *");
            Console.WriteLine("***************************");
        }

        public static void button()
        {
            Console.Write("Press any key to continue...:");
            Console.ReadKey();
        }

        public static char AdminMenu()
        {
            char op;

            Console.Clear();
            head();
            Console.WriteLine(" Admin Menu >> \n");
            Console.WriteLine(" 1. Add Product ");
            Console.WriteLine(" 2. View All Products");
            Console.WriteLine(" 3. Find Product with Highest unit price");
            Console.WriteLine(" 4. View sales Tax of all Products");
            Console.WriteLine(" 5. Products to be ordered");
            Console.WriteLine(" 6. EXIT ");

            Console.Write(" Your Option : ");
            op = char.Parse(Console.ReadLine());
            return op;
        }

        public static char CustomerMenu()
        {
            char op;
            Console.Clear();
            head();
            Console.WriteLine(" Customer Menu >>");
            Console.WriteLine(" 1. View All Products ");
            Console.WriteLine(" 2. Buy Product ");
            Console.WriteLine(" 3. Generate Invoice");
            Console.WriteLine(" 4. EXIT");

            Console.Write(" Your Option...: ");
            op = char.Parse(Console.ReadLine());
            return op;
        }
    }
}
