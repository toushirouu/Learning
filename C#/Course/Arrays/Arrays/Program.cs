using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = { 4, 8, 15, 16, 23, 42 };
            Console.WriteLine(luckyNumbers[0]);
            luckyNumbers[0] = 32;
            Console.WriteLine(luckyNumbers[0]);

            string[] friends = { "Mike", "Bob", "John" };
            Console.WriteLine(friends[0]);
          

            int[] numbers = new int[3];
            numbers[0] = 4;
            numbers[1] = 3;
            numbers[2] = 55;
            Console.WriteLine(numbers[0] + numbers[1]+ numbers[2]);

            Console.ReadLine();


        }
    }
}
