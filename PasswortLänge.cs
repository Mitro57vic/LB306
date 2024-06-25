namespace PasswortGenerator
{
    public class PasswortLänge
    {
        private Menu menu;
        private int passwortLänge = 0;

        public PasswortLänge(Menu menu)
        {
            this.menu = menu;
        }

        public void LängeÄndern()
        {
            Console.WriteLine("Zuerst müssen wir die Passwortlänge definieren");
            Console.WriteLine("Wie lang sollte das Passwort sein?");

            while (true)
            {
                try
                {
                    passwortLänge = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Ungültige Eingabe, Bitte verwende nur Zahlen.");
                    continue;
                }   

                if (passwortLänge <= 20)
                {
                    Console.WriteLine("Das ist aber zu kurz, bitte gebe ein genug langes ein");
                }
                else if (passwortLänge >= 50)
                {
                    Console.WriteLine("Das ist aber ein wenig zu lang, bitte gebrauche ein kürzeres");
                }
                else
                {
                    Console.WriteLine("Super, dein Passwort wird " + passwortLänge + " Zeichen lang sein.");

                    menu.StartPasswortZeichen(passwortLänge);
                    break;
                }
            }
        }
    }
}