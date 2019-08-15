using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 6;
            num++;
            num--;
            Console.WriteLine(-5.78 + 3.23);
            Console.WriteLine(5 / 2);
            Console.WriteLine(5 % 2);
            Console.WriteLine(4 + 2 * 3);
            Console.WriteLine(( 4 + 2) * 3);
            Console.WriteLine(5 / 2.0);

            Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(3, 2));
            Console.WriteLine(Math.Sqrt(36));
            Console.WriteLine(Math.Max(3,30));
            Console.WriteLine(Math.Min(3, 30));
            Console.WriteLine(Math.Round(4.3));
            Console.WriteLine(Math.Round(4.6));


            Console.ReadLine();
        }
    }
}
