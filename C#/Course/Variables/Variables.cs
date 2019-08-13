using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "John";
            int characterAge;
            characterAge = 25;
            Console.WriteLine("Here once wasa a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");
            characterName = "Martin";
            Console.WriteLine("He really liked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);

            Console.ReadKey();

        }
    }
}
