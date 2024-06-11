namespace PasswortGenerator
{
    public class Menu
    {
        private int passwortLänge;
        private bool[] selectedOptions;

        public void StartPasswortLänge()
        {
            Console.WriteLine("Willkommen beim Passwort Generator, hier kannst du dein Passwort generieren lassen.");
            
            PasswortLänge passwortLänge = new PasswortLänge(this);
            passwortLänge.LängeÄndern();
        }

        public void StartPasswortZeichen(int passwortLänge)
        {
            this.passwortLänge = passwortLänge;
            Console.Clear();

            PasswortZeichen passwortZeichen = new PasswortZeichen(this);
            passwortZeichen.Zeichen();
        }

        public void StartPasswortGenerieren(bool[] selectedOptions)
        {
            this.selectedOptions = selectedOptions;
            Console.Clear();

            PasswortGenerator passwortGenerator = new PasswortGenerator();
            passwortGenerator.PasswortGenerieren(passwortLänge, selectedOptions);
        }
    }
}