using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Return_Statement
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(cube(5)); // albo int wynik = cube(5);
                                        //      Console.WriteLine(wynik);
        }

        static int cube (int number)
        {
            int result = number * number;
            return result;
        }
    }
}
