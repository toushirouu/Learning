using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("loooool");
            Book book1 = new Book("","",0);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
        }
    }
}
