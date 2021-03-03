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
            Sportart = sportart;
        }

        public Schiedsrichter(string name, string rolle, int nummer, string sportart) : base(name, rolle, nummer)
        {
            Sportart = sportart;
        }

        #endregion

        #region Worker

        public void Pfeifen(){}

        #endregion

    }
}