using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    public class Teilnehmer
    {
        #region Properties
        private string _name;
        private string _rolle;
        private int _nummer;
        #endregion

        #region Accessors/Modifiers
        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Rolle
        {
            get => _rolle;
            set => _rolle = value;
        }
        public int Nummer { get => _nummer; set => _nummer = value; }
        #endregion
        #region Constructor

        public Teilnehmer()
        {
            Name = " ";
            Rolle = " ";
        }

        public Teilnehmer(string name, string rolle, int nummer)
        {
            Name = name;
            Rolle = rolle;
            Nummer = nummer;
        }
        #endregion
        #region Worker

        public void anmelden(){}

        #endregion

    }
}