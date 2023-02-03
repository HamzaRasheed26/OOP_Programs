using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAMS.UI
{
    internal class UAMS_UI
    {
        public static void head()
        {
            Console.WriteLine("*****************************");
            Console.WriteLine("*        *** UAMS ***       *");
            Console.WriteLine("*****************************");
        }

        public static string Menu()
        {
            Console.Clear();
            head();
            string op = "";

            Console.WriteLine(" 1. Add Student");
            Console.WriteLine(" 2. Add Degree Program");
            Console.WriteLine(" 3. Generate Merit");
            Console.WriteLine(" 4. View REgistered Students");
            Console.WriteLine(" 5. View Students of a Specific Students");
            Console.WriteLine(" 6. REgister Subject for a Specific Student");
            Console.WriteLine(" 7. Calculate Fees for all Registered Students");
            Console.WriteLine(" 8. Exit");
            Console.Write(" Your Option.....:");
            op = Console.ReadLine();
            return op;
        }
    }
}
