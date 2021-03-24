using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Turnierverwaltung
{
    public class Mannschaft : Teilnehmer
    {
        private string _name;
        private List<Teilnehmer> _mitglieder;

        #region Accessors/Modifiers

        public string Name1
        {
            get => _name;
            set => _name = value;
        }

        public List<Teilnehmer> Mitglieder
        {
            get => _mitglieder;
            set => _mitglieder = value;
        }

        #endregion

        #region Constructor

        public Mannschaft(string name, List<Teilnehmer> mitglieder)
        {
            Name = name;
            Mitglieder = mitglieder;
        }

        public Mannschaft(string name, string vorname, string rolle, int nummer, List<Teilnehmer> mitglieder) : base(name, vorname, "Mannschaft", nummer)
        {
            Name = name;
            Mitglieder = mitglieder;
        }

        #endregion

        #region Worker

        public void neuesMitgliedHnzufuegen(){}
        public void MitgliedEntfernen(){}

        public override void DatenSpeichern()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}