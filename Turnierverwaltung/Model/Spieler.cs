using MySql.Data.MySqlClient;

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
            Position = " ";
            Spielernummer = 0;
        }

        public Spieler(int spielernummer, string position)
        {
            Spielernummer = spielernummer;
            Position = position;
        }

        public Spieler(string name, string rolle, int nummer, int spielernummer, string position) : base(name, rolle, nummer)
        {
            Spielernummer = spielernummer;
            Position = position;
        }

        #endregion

        #region Worker

        public void BallPassen(){}

        #endregion
    }
}