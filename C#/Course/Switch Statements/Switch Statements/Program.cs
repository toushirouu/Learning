using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj dzien tygodnia od 0 - 6 (Biorac pod uwage ze tydzien zaczyna sie od niedzieli): ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetDay(day));
            Console.ReadLine();

        }

        static string GetDay(int num)
        {
            string dayNum;

            switch (num)
            {
                case 0:
                    dayNum = "Sunday";
                    break;

                case 1:
                    dayNum = "Monday";
                    break;

                case 2:
                    dayNum = "Tuesday";
                    break;

                case 3:
                    dayNum = "Wednesday";
                    break;

                case 4:
                    dayNum = "Thursday";
                    break;

                case 5:
                    dayNum = "Friday";
                    break;

                case 6:
                    dayNum = "Saturday";
                    break;

                default:
                    dayNum = "Invaild day number";
                    break;


            }
            
                


            return dayNum;


        }
    }
}
