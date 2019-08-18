using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2dArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] myArray =
            {
                { 3,2 },
                { 4,1 },
                { 12,3}
            };
            int[,] nextArray = new int[2, 3]; // ilosc rzedow i kolum

            Console.WriteLine(myArray[0,0]);
            Console.WriteLine(myArray[2,0]);

            Console.ReadLine();
        }
    }
}
