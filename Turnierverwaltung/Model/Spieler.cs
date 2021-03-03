namespace Turnierverwaltung
{
    public class Spieler : Teilnehmer
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

        public Spieler()
        {
            Position = _position;
            Spielernummer = _spielernummer;
        }

        public Spieler(int spielernummer, string position)
        {
            _spielernummer = spielernummer;
            _position = position;
        }

        public Spieler(string name, string rolle, int spielernummer, string position) : base(name, rolle)
        {
            _spielernummer = spielernummer;
            _position = position;
        }

        #endregion

        #region Worker

        public void BallPassen(){}

        #endregion
    }
}