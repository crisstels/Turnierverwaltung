﻿using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;


namespace Turnierverwaltung
{
    class Materialwart : Teilnehmer
    {
        #region Properties
        private string _material;
        private int _materialwartId;
        #endregion

        #region Accessors/ Modifiers
        public string Material { get => _material; set => _material = value; }
        public int MaterialwartId { get => _materialwartId; set => _materialwartId = value; }
        #endregion

        #region Constructor
        public Materialwart()
        {
            Material = " ";
        }

        public Materialwart(string name, string vorname, string rolle, int nummer, int materialwartID, string material ) : base(name, vorname, rolle, nummer)
        {
            MaterialwartId = materialwartID;
            Material = material;
        }
        #endregion

        #region Worker
        public void MaterialAusgeben()
        {
            Console.WriteLine("{0} wurde ausgegeben.", Material);
        }

        public override void DatenSpeichern()
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

            string insertTeilnehmer = "insert into Teilnehmer values('" + Nummer + "', '" + Rolle + "', '" + Name + "', '" + Vorname + "');";
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

            string insertMaterialwart = "insert into Materialwart values('" + Nummer + "', '" + MaterialwartId + "', '" + Material + "');";
            SQLiteCommand command1 = new SQLiteCommand(insertMaterialwart, Connection);
            anzahl = -1;

            try
            {
                anzahl = command1.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            if (anzahl > 0)
            {
                Console.WriteLine(anzahl);
            }

            // Close connection
            Connection.Close();
        }
        #endregion
    }
}
