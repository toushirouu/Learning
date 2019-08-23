using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book();

            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;

            book2.title = "Lord of the Rings";
            book2.author = "Tolkien";
            book2.pages = 700;

            Console.WriteLine(book1.author);
            Console.WriteLine(book2.title);

            Console.ReadLine();

        }
    }
}