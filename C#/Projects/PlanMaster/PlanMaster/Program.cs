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
            MainMenu();
            int num1 = Convert.ToInt32(Console.ReadLine());

            do
            {

            } while (); //in progress

            PlanMenu();
            int i = 1;
            int num = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (i > 2)
                {
                    Console.WriteLine();
                    PlanMenu();
                    int number = Convert.ToInt32(Console.ReadLine());
                    num = number;
                }
                switch (num)
                {
                    case 1:
                        ThreeDaysPlan();
                        break;

                    case 2:
                        FourDaysPlan();
                        break;

                    case 3:
                        FiveDaysPlan();
                        break;

                    default:
                        Console.WriteLine("Błędna na wartość");
                        break;
                }
                i++;
            } while (num > 2 || num < 0);
        }

        static string MainMenu()
        {
            Console.Write("Witaj w Plan Master, wciśnij dowolny klawisz, aby kontunować: ");
            Console.ReadKey();
            Console.WriteLine("");
            Console.WriteLine("Plany treningowe - wciśnij 1");
            Console.WriteLine("Kalkulator kalorii - wciśnij 2");
            Console.WriteLine("Plany żywienia - wciśnij 3");
            Console.WriteLine("");
            return "";
        }

        static string PlanMenu()
        {
            Console.Write("Wybierz dwolony plan treningowy: ");
            Console.WriteLine();
            Console.WriteLine("Wybierz plan treningowy: ");
            Console.WriteLine("");
            Console.WriteLine("Plan na trzy dni - wciśnij 0");
            Console.WriteLine("Plan na cztery dni - wciśnij 1");
            Console.WriteLine("Plan na pięć dni - wciśnij 2");
            Console.WriteLine("");
            return "";
        }
        static string ThreeDaysPlan()
        {
            Console.WriteLine("Plan na trzy dni");

            return "";
        }
        static string FourDaysPlan()
        {
            Console.WriteLine("Plan na cztery dni");

            return "";
        }

        static string FiveDaysPlan()
        {
            Console.WriteLine("Plan na pięć dni");

            return "";
        }

    }

}