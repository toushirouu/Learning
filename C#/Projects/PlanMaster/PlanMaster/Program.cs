using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanMaster
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();


            int i = 0;
            int num = Convert.ToInt32(Console.ReadLine());
            do
            {


                if (i == 1)
                {
                    Console.WriteLine();
                    Menu();
                    int number = Convert.ToInt32(Console.ReadLine());
                    num = number;

                }
              

                switch (num)
                {
                    case 0:
                        Console.WriteLine("Plan na trzy dni");
                        break;

                    case 1:
                        Console.WriteLine("Plan na trzy dni");
                        break;

                    case 2:
                        Console.WriteLine("Plan na trzy dni");
                        break;

                    default:
                        Console.WriteLine("Błędny klawisz, spróbuj jeszcze raz");

                        break;

                }
                i++;
            } while (num > 2 || num < 0);
            Console.WriteLine(num);

        }
        static string Menu()
        {
            Console.Write("Witaj w Plan Master, aby kontynuować wciśnij dowolny klawisz: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Wybierz plan treningowy: ");
            Console.WriteLine();
            Console.WriteLine("Plan na trzy dni - wciśnij 0");
            Console.WriteLine("Plan na cztery dni - wciśnij 1");
            Console.WriteLine("Plan na pięć dni - wciśnij 2");
            Console.WriteLine();
            return "";
            
        }
       
    }

}

 

