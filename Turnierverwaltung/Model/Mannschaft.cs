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
            _name = name;
            _mitglieder = mitglieder;
        }

        public Mannschaft(string name, string rolle, List<Teilnehmer> mitglieder) : base(name, "Mannschaft")
        {
            _name = name;
            _mitglieder = mitglieder;
        }

        #endregion

        #region Worker

        public void neuesMitgliedHnzufuegen(){}
        public void MitgliedEntfernen(){}

        #endregion
    }
}