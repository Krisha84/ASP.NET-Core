using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestF
{
    internal class Book
    {
        public int BookID;
        public string Title;
        public string Author;
        public Book(int bookID, string title, string author)
        {
            this.BookID = bookID;
            this.Title = title;
            this.Author = author;
        }
        public void DisplayBookDetails()
        {
            Console.WriteLine("Book ID : " + BookID + " , Title : "  + Title + " , Author : " + Author);
        }
    }
}
