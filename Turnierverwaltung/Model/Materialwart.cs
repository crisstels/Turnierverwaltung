using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;


namespace Turnierverwaltung
{
    class Materialwart : Teilnehmer
    {
        #region Properties
        private string _material;
        #endregion

        #region Accessors/ Modifiers
        public string Material { get => _material; set => _material = value; }
        #endregion

        #region Constructor
        public Materialwart()
        {
            Material = " ";
        }

        public Materialwart(string material, string name, string vorname, string rolle, int nummer) : base(name, vorname, rolle, nummer)
        {
            Material = material;
        }
        #endregion

        #region Worker
        public void MaterialAusgeben()
        {
            Console.WriteLine("{0} wurde ausgegeben.", Material);
        }

        public override void DatenSpeichern()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
