namespace PasswortGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartProgram();
        }

        public static void StartProgram()
        {
            Console.Clear();
            Menu menu = new Menu();
            menu.StartPasswortLänge();
        }
    }
}