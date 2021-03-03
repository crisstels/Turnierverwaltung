namespace Turnierverwaltung
{
    public class Organisator : Teilnehmer
    {
        #region Properties

        private int _anzahlTurniere;

        #endregion

        #region Accessors/Modifiers

        public int AnzahlTurniere
        {
            get => _anzahlTurniere;
            set => _anzahlTurniere = value;
        }

        #endregion

        #region Constructor

        public Organisator()
        {
            AnzahlTurniere = 0;
        }

        public Organisator(int anzahlTurniere)
        {
            _anzahlTurniere = anzahlTurniere;
        }

        public Organisator(string name, string rolle, int anzahlTurniere) : base(name, "Organisator")
        {
            _anzahlTurniere = anzahlTurniere;
        }

        #endregion

        #region Worker

        public void Organisiert(){}

        #endregion
    }
}