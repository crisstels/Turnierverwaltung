using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;


namespace Turnierverwaltung
{
    class Physio : Teilnehmer
    {
        #region Properties
        private int _jahreErfahrung;
        #endregion

        #region Accessors/Modifiers
        public int JahreErfahrung { get => _jahreErfahrung; set => _jahreErfahrung = value; }
        #endregion

        #region Constructor
        public Physio() {
            JahreErfahrung = 0;
        }

        public Physio(int jahreErfahrung, string name, string rolle, int nummer) : base(name, rolle, nummer)
        {
            JahreErfahrung = jahreErfahrung;
        }
        #endregion

        #region Worker
        public void heileSpieler(int spielerNummer)
        {
            Console.WriteLine("Der Spieler mit der Nummer {0} wird geheilt.", spielerNummer);
        }
        #endregion

    }
}
