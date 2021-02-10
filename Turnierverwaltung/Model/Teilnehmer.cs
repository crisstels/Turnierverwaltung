namespace Turnierverwaltung
{
    public class Teilnehmer
    {
        #region Properties
        private string _name;
        private string _rolle;
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
        #endregion
        #region Constructor
        
        public Teilnehmer()
        {
            this.Name = Name;
            this.Rolle = Rolle;
        }

        public Teilnehmer(string name, string rolle)
        {
            _name = name;
            _rolle = rolle;
        }
        #endregion
        #region Worker

        public void anmelden(){}

        #endregion

    }
}