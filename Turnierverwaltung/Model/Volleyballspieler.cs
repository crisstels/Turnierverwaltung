using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    public class Volleyballspieler : Teilnehmer
    {
        #region Properties

        private int _spielernummer;
        private string _position;

        #endregion

        #region Accessors/Modifiers

        public int Spielernummer
        {
            get => _spielernummer;
            set => _spielernummer = value;
        }

        public string Position
        {
            get => _position;
            set => _position = value;
        }

        #endregion

        #region Constructor

        public Volleyballspieler()
        {
            Position = " ";
            Spielernummer = 0;
        }

        public Volleyballspieler(int spielernummer, string position)
        {
            Spielernummer = spielernummer;
            Position = position;
        }

        public Volleyballspieler(string name, string rolle, int nummer, int spielernummer, string position) : base(name, rolle, nummer)
        {
            Spielernummer = spielernummer;
            Position = position;
        }

        #endregion

        #region Worker

        public void BallPassen(){}

        public override void InsertData()
        {
            string DatabasePath = "D:/Users/NatalieHasselmann/Documents/2.Lehrjahr/AWE/TurnierDatenbank/turnier.db";
            string connectionString = "Data Source=" + DatabasePath + ";Version=3;";

            SQLiteConnection Connection = new SQLiteConnection(connectionString);
            int anzahl = -1;

            // Open Database Connection
            try
            {
                Connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return;
            }

            // speichert zuerst die Daten in die Teilnehmertabelle
            int nummer = Nummer;
            string name = Name;
            string rolle = Rolle;

            string insertTeilnehmer = "insert into Teilnehmer values('" + nummer + "', '" + rolle + "', '" + name + "');";
            SQLiteCommand command = new SQLiteCommand(insertTeilnehmer, Connection);

            try
            {
                anzahl = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (anzahl > 0)
            {
                Console.WriteLine(anzahl);
            }

            // speichert nun die Daten in die Spielertabelle

            int Trikotnummer = Spielernummer;
            string position = Position;

            string insertSpieler = "insert into Teilnehmer values('" + Trikotnummer + "', '" + position + "', '" + nummer + "');";
            SQLiteCommand command1 = new SQLiteCommand(insertSpieler, Connection);
            anzahl = -1;

            try
            {
                anzahl = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (anzahl > 0)
            {
                Console.WriteLine(anzahl);
            }

        }

        #endregion
    }
}