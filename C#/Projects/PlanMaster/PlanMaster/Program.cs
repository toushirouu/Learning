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
        }
        static void MainMenu()
        {
            int num;
            for (int m = 1; m <= 2; m++)
            {
                Console.Write("Witaj w Plan Master, wciśnij dowolny klawisz, aby kontunować: ");
                Console.ReadKey();
                Console.WriteLine("");
                Console.WriteLine("Plany treningowe - wciśnij 1");
                Console.WriteLine("Kalkulator kalorii - wciśnij 2");
                Console.WriteLine("Plany żywienia - wciśnij 3");
                Console.WriteLine("");

                num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        PlanMenu();
                        m++;
                        break;
                    case 2:
                        m++;
                        Console.WriteLine("test"); //in progress
                        break;
                    case 3:
                        m++;
                        Console.WriteLine("test"); //in progress
                        break;
                    default:
                        Console.WriteLine("Błędna wartość");
                        m--;
                        break;
                }
            }
        }
        static void PlanMenu()
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Wybierz dwolony plan treningowy: ");
                Console.WriteLine();
                Console.WriteLine("Wybierz plan treningowy: ");
                Console.WriteLine("");
                Console.WriteLine("Plan na trzy dni - wciśnij 1");
                Console.WriteLine("Plan na cztery dni - wciśnij 2");
                Console.WriteLine("Plan na pięć dni - wciśnij 3");
                Console.WriteLine("Powrót do menu głównego - wciśnij 4");
                Console.WriteLine("");

                int num = Convert.ToInt32(Console.ReadLine());

                switch (num)
                {
                    case 1:
                        ThreeDaysPlan();
                        i++;
                        break;

                    case 2:
                        FourDaysPlan();
                        i++;
                        break;

                    case 3:
                        FiveDaysPlan();
                        i++;
                        break;
                    case 4:
                        MainMenu();
                        i++;
                        break;

                    default:
                        Console.WriteLine("Błędna wartość");
                        i--;
                        break;
                }

            }
        }
        static void ThreeDaysPlan()
        {
            Console.WriteLine("Plan na trzy dni");

           
        }
        static void FourDaysPlan()
        {
            Console.WriteLine("Plan na cztery dni");

            
        }

        static void FiveDaysPlan()
        {
            Console.WriteLine("Plan na pięć dni");

           
        }

    }

}