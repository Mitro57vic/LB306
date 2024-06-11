namespace PasswortGenerator
{
    public class PasswortZeichen
    {
        private Menu menu;
        public int SelectedOption { get; set; } = 1;
        private bool[] selected = new bool[3]; // Array zum Speichern der Auswahlzustände

        public PasswortZeichen(Menu menu)
        {
            this.menu = menu;
        }

        public void Zeichen()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Hier musst du die nötigen Zeichen aktivieren oder deaktivieren, die du in deinem Passwort haben möchtest.");
                Console.WriteLine("Wenn du nichts aktivierst wird das Passwort standardmässig mit Buchstaben, Zahlen und Sonderzeichen generiert.");
                Console.Write("Wähle mittels der ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Leertaste");
                Console.ResetColor();
                Console.Write(" die Optionen aus. Mit der ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Entertaste");
                Console.ResetColor();
                Console.WriteLine(" akzeptierst du und fährst fort zum Generieren.");

                // Zeichnen der Optionen mit Grün, falls aktiviert
                if (SelectedOption == 1)
                {
                    Console.ForegroundColor = selected[0] ? ConsoleColor.Green : ConsoleColor.White;
                    Console.WriteLine(">  Buchstaben");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(selected[0] ? "   \u001b[32mBuchstaben\u001b[0m" : "   Buchstaben");
                }

                if (SelectedOption == 2)
                {
                    Console.ForegroundColor = selected[1] ? ConsoleColor.Green : ConsoleColor.White;
                    Console.WriteLine(">  Zahlen");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(selected[1] ? "   \u001b[32mZahlen\u001b[0m" : "   Zahlen");
                }

                if (SelectedOption == 3)
                {
                    Console.ForegroundColor = selected[2] ? ConsoleColor.Green : ConsoleColor.White;
                    Console.WriteLine(">  Sonderzeichen");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine(selected[2] ? "   \u001b[32mSonderzeichen\u001b[0m" : "   Sonderzeichen");
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.W || key == ConsoleKey.UpArrow)
                {
                    SelectedOption = SelectedOption == 1 ? 3 : SelectedOption - 1;
                }
                else if (key == ConsoleKey.S || key == ConsoleKey.DownArrow)
                {
                    SelectedOption = SelectedOption == 3 ? 1 : SelectedOption + 1;
                }
                else if (key == ConsoleKey.Spacebar)
                {
                    selected[SelectedOption - 1] = !selected[SelectedOption - 1];
                }
                else if (key == ConsoleKey.Enter)
                {
                    break;
                }
            }
            
            Console.Clear();
            menu.StartPasswortGenerieren(selected);
        }
        
        // Methode zum Abrufen der ausgewählten Optionen
        public bool[] GetSelectedOptions()
        {
            return selected;
        }
    }
}
