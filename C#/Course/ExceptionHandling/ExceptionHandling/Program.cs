using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
        
            try
            {
                Console.Write("Type first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Type first number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                int result;
                Console.WriteLine(result = (num1 / num2));

            }

            catch (Exception s)                     // mozna uzyc tez wybranych wyjatkow, np. DivideByZeroException, FormatException
            {
                Console.WriteLine(s.Message);       

            }
            

           

        }
    }
}
