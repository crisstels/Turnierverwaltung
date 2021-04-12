using System;
using System.Collections;
using System.Linq;
using System.Web;
using System.Data.SQLite;

namespace Turnierverwaltung
{
    public class Controller
    {
        public void ErfasseSpielerDaten()
        {

            UserInterface userinterface = new UserInterface();
            Volleyballspieler spieler =  userinterface.SpielerDatenAufnehmen();
            spieler.DatenSpeichern();
        }
        public void run()
        {
            /*Volleyballspieler spieler1 = new Volleyballspieler("Mustermann", "Max", "Volleyballspieler", 1, 4, "Libero");

            spieler1.DatenSpeichern();

            Trainer trainer1 = new Trainer("Schmitz", "Jürgen", "Trainer", 2, 1, "Volleyball", 12);

            trainer1.DatenSpeichern();

            Physio pyhsio1 = new Physio("Müller", "Anna", "Physio", 3, 1, 15);

            pyhsio1.DatenSpeichern();

            Materialwart materialwart = new Materialwart("Waerter", "Laura", "Materialwart", 5, 1, "Volleybaelle, Netze");

            materialwart.DatenSpeichern(); */

            ErfasseSpielerDaten();
        }
    }
}