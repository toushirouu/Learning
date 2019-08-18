using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            while (index <= 10)
            {
                Console.WriteLine(index);
                index++;
            }

            index = 11; // roznica pomiedzy while, a do while, do while najpierw wykonuje a potem sprawdza warunek, wiec nawet jesli warunek jest niezgodny to pierwsza runda petli zostanie wykonana

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 10);
        }
    }
}
