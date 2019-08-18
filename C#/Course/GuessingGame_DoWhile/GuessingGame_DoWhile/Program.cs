using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame_DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {

            string guessingWord = "giraffe";
            string guess = "";
            int guessingCount = 0;
            int guessingMax = 3;

            bool outOfGuessing = false;

            do
            {
                if (guessingCount < guessingMax)
                {
                    Console.Write("Enter guess: ");
                    guess = Console.ReadLine();
                    guessingCount++;
                }

                else
                {
                    outOfGuessing = true;

                }
            }

            while (guess != guessingWord && outOfGuessing == false);

            if (guess == guessingWord)
            {
                 Console.WriteLine("You Win!");
                 Console.WriteLine("You won in " + guessingCount + " try" );
            }

            else
            {
                Console.WriteLine("You lose");
            }
            
        }
    }
}
