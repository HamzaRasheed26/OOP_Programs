using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarySystem.BL
{
    internal class Book
    {
        // Constructors
        public Book(string Author, string Title, int pages, int price, List<string> Chapters)
        {
            this.Author = Author;
            this.Title = Title;
            this.pages = pages;
            this.price = price;
            this.Chapters = Chapters;
        }

        // Data Memebers
        public string Author;
        public int pages;
        public string Title;
        public List<string> Chapters = new List<string>();
        public int bookMark;
        public int price;

        // Member Function
        public string getChapter( int chpNo)
        {
            if ( chpNo > 0 && chpNo < Chapters.Count)
            {
                chpNo--;
                return Chapters[chpNo];
            }
            else
            {
                return "Chapter Not Exist";
            }
        }

        public void setBookMark(int pageNo)
        {
            if(pageNo > 0 && pageNo <= pages)
            {
                bookMark = pageNo;
            }
            else
            {
                Console.WriteLine("Out Of Range");
            }
        }

        public int getBookMark()
        {
            if (bookMark == 0)
            {
                Console.WriteLine("No BookMark Set");
            }
            return bookMark;
        }

        public int getBookPrice()
        {
            return price;
        }

        public void setBookPrice( int price)
        {
            this.price = price;
        }

        public void AddChapter(string chapter)
        {
            Chapters.Add(chapter);
        }
    }
}
