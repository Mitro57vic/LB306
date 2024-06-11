using System.Text;

namespace PasswortGenerator
{
    public class PasswortGenerator
    {
        public void PasswortGenerieren(int passwortLänge, bool[] ausgewählteOptionen)
        {
            Random rnd = new Random();
            StringBuilder passwort = new StringBuilder();

            var mapping = new Dictionary<int, char> //Mapping für alle Zeichen, die Generiert werden können.
            {
                { 1, '1' }, 
                { 2, '2' }, 
                { 3, '3' }, 
                { 4, '4' }, 
                { 5, '5' },
                { 6, '6' },
                { 7, '7' },
                { 8, '8' },
                { 9, '9' },
                
                { 10, 'a' },
                { 11, 'b' },
                { 12, 'c' },
                { 13, 'd' },
                { 14, 'e' },
                { 15, 'f' },
                { 16, 'g' },
                { 17, 'h' },
                { 18, 'i' },
                { 19, 'j' },
                { 20, 'k' },
                { 21, 'l' },
                { 22, 'm' },
                { 23, 'n' },
                { 24, 'o' },
                { 25, 'p' },
                { 26, 'q' },
                { 27, 'r' },
                { 28, 's' },
                { 29, 't' },
                { 30, 'u' },
                { 31, 'v' },
                { 32, 'w' },
                { 33, 'x' },
                { 34, 'y' },
                { 35, 'z' },
                
                { 36, 'A' },
                { 37, 'B' },
                { 38, 'C' },
                { 39, 'D' },
                { 40, 'E' },
                { 41, 'F' },
                { 42, 'G' },
                { 43, 'H' },
                { 44, 'I' },
                { 45, 'J' },
                { 46, 'K' },
                { 47, 'L' },
                { 48, 'M' },
                { 49, 'N' },
                { 50, 'O' },
                { 51, 'P' },
                { 52, 'Q' },
                { 53, 'R' },
                { 54, 'S' },
                { 55, 'T' },
                { 56, 'U' },
                { 57, 'V' },
                { 58, 'W' },
                { 59, 'X' },
                { 60, 'Y' },
                { 61, 'Z' },
                
                { 62, '+' },
                { 63, '"' },
                { 64, '*' },
                { 65, 'ç' },
                { 66, '%' },
                { 67, '&' },
                { 68, '/' },
                { 69, '(' },
                { 70, ')' },
                { 71, '=' },
                { 72, '?' },
                { 73, '!' },
                { 74, '£' },
                { 75, '[' },
                { 76, '}' },
                { 77, '{' },
                { 78, '@' },
                { 79, '#' },
                { 80, '|' }
            };

            for (int j = 0; j < passwortLänge; j++)
            {
                int randomKey;

                if (ausgewählteOptionen[0] && ausgewählteOptionen[1] && ausgewählteOptionen[2])
                {
                    // Wenn alle Optionen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 80
                    randomKey = rnd.Next(1, 81);
                }
                else if (ausgewählteOptionen[0] && ausgewählteOptionen[1])
                {
                    // Wenn nur Buchstaben und Zahlen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 61
                    randomKey = rnd.Next(1, 62);
                }
                else if (ausgewählteOptionen[0] && ausgewählteOptionen[2])
                {
                    // Wenn nur Buchstaben und Sonderzeichen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 35 oder 62 und 80
                    randomKey = rnd.Next(1, 36);
                    if (rnd.NextDouble() > 0.5)
                    {
                        randomKey = rnd.Next(62, 81);
                    }
                }
                else if (ausgewählteOptionen[1] && ausgewählteOptionen[2])
                {
                    // Wenn nur Zahlen und Sonderzeichen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 9 oder 62 und 80
                    randomKey = rnd.Next(1, 10);
                    if (rnd.NextDouble() > 0.5)
                    {
                        randomKey = rnd.Next(62, 81);
                    }
                }
                else if (ausgewählteOptionen[0])
                {
                    // Wenn nur Buchstaben ausgewählt sind, generieren Sie eine Zufallszahl zwischen 10 und 61
                    randomKey = rnd.Next(10, 62);
                }
                else if (ausgewählteOptionen[1])
                {
                    // Wenn nur Zahlen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 9
                    randomKey = rnd.Next(1, 10);
                }
                else if (ausgewählteOptionen[2])
                {
                    // Wenn nur Sonderzeichen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 62 und 80
                    randomKey = rnd.Next(62, 81);
                }
                else
                {
                    // Wenn keine Optionen ausgewählt sind, generieren Sie eine Zufallszahl zwischen 1 und 80
                    randomKey = rnd.Next(1, 81);
                }

                // Fügen Sie das entsprechende Zeichen zum Passwort hinzu
                passwort.Append(mapping[randomKey]);
            }

            while (true)
            {
                // Geben Sie das generierte Passwort zurück
                Console.WriteLine(passwort);
                Console.WriteLine("\r\n   ");
                Console.WriteLine("Bist du Zufrieden mit deinem Passwort?");
                
                Console.Write("Wenn die ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Umschalttaste");
                Console.ResetColor();
                Console.WriteLine(" gedrückt wird, starten Sie das Programm neu");
                
                Console.Write("Wenn die ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Entertaste");
                Console.ResetColor();
                Console.WriteLine(" gedrückt wird, generieren Sie ein neues Passwort mit den gleichen Einstellungen");
            
                Console.Write("Wenn die ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Escapetaste");
                Console.ResetColor();
                Console.WriteLine(" gedrückt wird, beenden Sie das Programm");
                
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            
                if (//keyInfo.Key == ConsoleKey.Enter &&
                    keyInfo.Key == ConsoleKey.Tab)
                {
                    // Wenn die Umschalttaste gedrückt wird, startet das Program neu
                    Console.Clear();
                    Program.StartProgram();
                }
                else if (keyInfo.Key == ConsoleKey.Enter)
                {
                    //Passwort neu generieren mit den gleichen Optionen
                    Console.Clear();
                    PasswortGenerieren(passwortLänge, ausgewählteOptionen);
                }
                else if (keyInfo.Key == ConsoleKey.Escape)
                {
                    // Wenn die Escapetaste gedrückt wird, beenden Sie das Programm
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }
    }
}
