using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PointAndLine.BL;
using PointAndLine.DL;
using PointAndLine.UI;

namespace PointAndLine.UI
{
    internal class ProgramUI
    {
        public static void Head()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("*    Point And Line   *");
            Console.WriteLine("***********************");
        }

        public static string Menu()
        {
            Console.Clear();
            Head();
            string op;
            Console.WriteLine(" Menu >> ");
            Console.WriteLine(" 1. Make a Line");
            Console.WriteLine(" 2. Update the begin point");
            Console.WriteLine(" 3. Update the end point");
            Console.WriteLine(" 4. Show the Begin point ");
            Console.WriteLine(" 5. Show the end point");
            Console.WriteLine(" 6. Get the Length of the line");
            Console.WriteLine(" 7. Get the Gradient of the line");
            Console.WriteLine(" 8. Find the distance of begin point from zero cordinates");
            Console.WriteLine(" 9. Find the distance of end point from zero coordintes");
            Console.WriteLine(" 10. EXIT ");
            Console.Write(" Your Option .... :");
            op = Console.ReadLine();
            return op;

        }
        public static void press()
        {
            Console.Write(" Press any key to continue ... ");
            Console.ReadKey();
        }

        public static void menuLines(string title)
        {
            Console.Clear();
            Head();
            Console.WriteLine("\n  " + title + " >> ");
        }
    }
}
