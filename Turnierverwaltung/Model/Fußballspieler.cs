namespace Turnierverwaltung
{
    public class Fußballspieler : Teilnehmer
    {
        #region Properties

        private int _spielernummer;
        private string _position;

        #endregion

        #region Accessors/Modifiers

        public int Spielnummer
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

        public Fußballspieler()
        {
            this._position = _position;
            this._spielernummer = _spielernummer;
        }

        public Fußballspieler(int spielernummer, string position)
        {
            _spielernummer = spielernummer;
            _position = position;
        }

        public Fußballspieler(string name, string rolle, int spielernummer, string position) : base(name, rolle)
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