using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        public Book(string aTitle, string aAuthor, int aPages)
        {

            aTitle = Console.ReadLine();
            aAuthor = Console.ReadLine();
            aPages = Convert.ToInt32(Console.ReadLine());
            title = aTitle;
            author = aAuthor;
            pages = aPages;


        }
    }
}

    
