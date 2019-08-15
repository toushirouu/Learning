using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = true;
            bool isTall = true;

            if (isMale && isTall)
            {
                Console.WriteLine("You are a male and you are tall");
            }
            else if (isMale &&!isTall)
            {
                Console.WriteLine("You are a male but you aren't tall");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You aren't male but you are tall");
            }
            else
            {
                Console.WriteLine("You aren't male and you aren't tall");
            }
        }
    }
}
