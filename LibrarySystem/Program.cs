using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibrarySystem.BL;

namespace LibrarySystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> chapters = new List<string> {"Wave", "Sound", "Dynamtics", "Nuclear"};
            Book physics = new Book("Newton", "Fundamental Of Physics", 1000, 500, chapters);

            Console.WriteLine(" Chapter :" + physics.getChapter(2));
            physics.setBookMark(452);
            Console.WriteLine(" book Mark :" + physics.getBookMark());
            Console.WriteLine(" Price : " + physics.getBookPrice());
            physics.setBookPrice(600);
            Console.WriteLine(" Price : " + physics.getBookPrice());
            physics.AddChapter("Force");

            Console.ReadKey();

        }
    }
}
