using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "giraffe";
            string guess = "";
            int index = 0;
            while (index <= 10 && guess != secretWord)
            {
                Console.Write("Enter guess: ");
                guess = Console.ReadLine();
                index++;
            }
            if (guess ==  secretWord)
            {
               Console.WriteLine("You Win!");
               Console.WriteLine("You won in " + index + " try");
            }
            else
            {
                Console.WriteLine("You lose :(");
            }
            
        }
    }
}
