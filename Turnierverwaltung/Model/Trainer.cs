using System;
using System.Collections.Generic;
using System.Text;

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
        #endregion
    }
}
