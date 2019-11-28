using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace Kseroprzycinanie
{
    class StartPoint
    {
        private static string record;
        static void Main(string[] args)
        {   
            DatabaseOperations db = new DatabaseOperations();
            Console.WriteLine("Podaj imie i nazwisko: ");
            record = Console.ReadLine();
            var result = record.Split(' ');
            db.ReadRecords();
            Console.ReadLine();
            //db.AddRecord(result[0],result[1]);

        }

    }
}