using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculator();

            Console.WriteLine("Calculating is over");
            Console.ReadLine();
        }

        static void Calculator()
        {
            Console.Write("Type first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op=="+")
            {
                Console.WriteLine(num1+num2);
            }
            else if (op=="-")
            {
                Console.WriteLine(num1-num2);
            }
            else if (op=="*")
            {
                Console.WriteLine(num1*num2);
            }
            else if (op=="/")
            {
                Console.WriteLine(num1/num2);
            }
            else
            {
                Console.WriteLine("Wrong operator");
            }
        }
    }
}
