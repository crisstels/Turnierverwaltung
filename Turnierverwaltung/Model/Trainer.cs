﻿using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace Turnierverwaltung.Model
{
    class Trainer : Teilnehmer
    {
        #region Properties

        private string _sportart;
        private int _erfahrung;
        #endregion

        #region Accessors/Modifiers
        public string Sportart { get => _sportart; set => _sportart = value; }
        public int Erfahrung { get => _erfahrung; set => _erfahrung = value; }
        #endregion

        #region Constructor
        public Trainer()
        {
            Sportart = "Fussball";
            Erfahrung = 0;
        }

        public Trainer(string name, string rolle, int nummer, string sportart, int erfahrung) : base(name, "Trainer", nummer)
        {
            Sportart = sportart;
            Erfahrung = erfahrung;
        }
        #endregion

        #region Worker
        public void trainieren() { }
        #endregion
    }
}
