using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kseroprzycinanie
{
    class DatabaseOperations
    {

        private SqlConnection polaczenie;
        private SqlCommand komenda;
        private SqlDataReader reader;
        public DatabaseOperations()
        {    
        }

        public void AddRecord(string imie, string nazwisko)
        {
            polaczenie = new SqlConnection(@"Server=DESKTOP-SJUPB9F\SQLEXPRESS;Database=Warsztat;Integrated Security=True;");
            polaczenie.Open();
            komenda = new SqlCommand($"INSERT INTO dbo.Klienci (Imie, Nazwisko) VALUES ('{imie}','{nazwisko}');", polaczenie);
            if (komenda.ExecuteNonQuery() == 1)
                Console.WriteLine("Dodano rekordów");
            else Console.WriteLine("chuj to strzelil");
            Console.ReadLine();
            polaczenie.Close();
        }
        public void ReadRecords()
        {
            polaczenie = new SqlConnection(@"Server=DESKTOP-SJUPB9F\SQLEXPRESS;Database=Warsztat;Integrated Security=True;");
            polaczenie.Open();
            komenda = new SqlCommand($"SELECT * FROM dbo.Klienci", polaczenie);
            reader = komenda.ExecuteReader();

            while(reader.Read())
            {
                Console.WriteLine($"{reader.GetInt32(0)},{reader.GetString(1)},{reader.GetString(2)}");
            }
        }

    }
}
