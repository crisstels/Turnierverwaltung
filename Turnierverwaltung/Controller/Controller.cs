namespace Turnierverwaltung
{
    public class Controller
    {
        public void run()
        {
            Volleyballspieler spieler1 = new Volleyballspieler("Mustermann", "Max", "Volleyballspieler", 1, 4, "Libero");

            //spieler1.DatenSpeichern();

            Trainer trainer1 = new Trainer("Schmitz", "Jürgen", "Trainer", 2, 1, "Volleyball", 12);

            //trainer1.DatenSpeichern();

            Physio pyhsio1 = new Physio("Müller", "Anna", "Physio", 3, 1, 15);

            pyhsio1.DatenSpeichern();
        }
    }
}