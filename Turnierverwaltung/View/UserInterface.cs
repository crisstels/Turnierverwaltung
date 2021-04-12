using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    public class UserInterface
    {
        public Volleyballspieler SpielerDatenAufnehmen()
        {
            Volleyballspieler spieler = new Volleyballspieler();

            Console.WriteLine("Bitte geben Sie Ihren Nachnamnen ein: ");
            spieler.Name = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihren Vornamen ein: ");
            spieler.Vorname = Console.ReadLine();

            Console.WriteLine("Bitte geben Sie Ihre Spielerposition an: ");
            spieler.Position = Console.ReadLine();

            Console.WriteLine("Ihre Trikotnummer: ");
            spieler.Spielernummer = Convert.ToInt32(Console.ReadLine());

            spieler.Rolle = "Volleyballspieler";

            return spieler;
        }
    }
}