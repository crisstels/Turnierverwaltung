using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;


namespace Turnierverwaltung
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
