using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List game1 = new List("The Witcher", "CD Projekt RED", "RPG");
            Console.WriteLine(game1.title);
            Console.WriteLine(game1.producer);
            Console.WriteLine(game1.type);

            Console.WriteLine();

            List game2 = new List("World of Warcraft", "Blizzard Entertainment", "MMORPG");
            Console.WriteLine(game2.title);
            Console.WriteLine(game2.producer);
            Console.WriteLine(game2.type);

            Console.ReadLine();
        }
    }
}
