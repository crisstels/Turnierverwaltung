using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    class Program
    {
        static void Main(string[] args)
        {
            string DatabasePath = "D:/Users/NatalieHasselmann/Documents/2.Lehrjahr/AWE/TurnierDatenbank/turnier.db";
            string connectionString = "Data Source=" + DatabasePath + ";Version=3;";

            SQLiteConnection Connection = new SQLiteConnection(connectionString);
            SQLiteDataReader reader = null;

            // Open Database Connection
            try
            {
                Connection.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            // Insert data into table Trainer
            int nummer = 1;
            string rolle = "Trainer";
            string sportart = "Handball";
            int jahreErfahrung = 3;
            int anzahl = -1;

            string insertQuery = "insert into Teilnehmer values('" + nummer + "', '" + rolle + "', '" + sportart + "', '" + jahreErfahrung + "');";
            SQLiteCommand command = new SQLiteCommand(insertQuery, Connection);

            try
            {
                anzahl = command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            if (anzahl > 0)
            {
                Console.WriteLine(anzahl);
            }

            //Select everything from trainer table
            string selectQuery = "Select * From Teilnehmer;";
            command = new SQLiteCommand(selectQuery, Connection);
            
            try
            {
                reader = command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string id = reader.GetValue(0).ToString();
                    string rolleD = reader.GetValue(1).ToString();
                    string sportartD = reader.GetValue(2).ToString();
                    string jahreErfahrungD = reader.GetValue(3).ToString();

                    Console.WriteLine("id: " + id);
                    Console.WriteLine("Rolle:" + rolleD);
                    Console.WriteLine("Sportart:" + sportartD); ;
                    Console.WriteLine("Jahre Erfahrung:" + jahreErfahrungD);

                }
            }
            else
            {
                Console.WriteLine("Error. Data is not inserted");
            }

            // close connections
            reader.Close();
            Connection.Close();
        }
    }
}