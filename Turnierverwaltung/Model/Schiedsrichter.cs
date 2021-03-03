namespace Turnierverwaltung
{
    public class Schiedsrichter : Teilnehmer
    {
        #region Properties

        private string _sportart;

        #endregion

        #region Accessors/Modifiers

        public string Sportart
        {
            get => _sportart;
            set => _sportart = value;
        }

        #endregion

        #region Constructor

        public Schiedsrichter()
        {
            Sportart = " ";
        }

        public Schiedsrichter(string sportart)
        {
            _sportart = sportart;
        }

        public Schiedsrichter(string name, string rolle, string sportart) : base(name, rolle)
        {
            _sportart = sportart;
        }

        #endregion

        #region Worker

        public void Pfeifen(){}

        #endregion

    }
}