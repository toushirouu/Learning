using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string phrase = "Giraffe Academy";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Academy"));
            Console.WriteLine(phrase.Contains("Academies"));
            Console.WriteLine(phrase.IndexOf("Academy"));
            Console.WriteLine(phrase.IndexOf('c'));
            Console.WriteLine(phrase.Substring(8));
            Console.WriteLine(phrase.Substring(8,5));

            Console.ReadKey();
        }
    }
}
