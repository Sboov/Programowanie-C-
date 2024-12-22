using System.Reflection.Metadata.Ecma335;
using System.Security.AccessControl;
using System.Xml.Serialization;

namespace Rock_Paper_Scissors
{
    internal class RockPaperScissors
    {
        static void Main(string[] args)
        {
            string wyborGracza = Player();
            string wyborKomputer = Computer();

            Console.WriteLine($"Wybór komputera to {wyborKomputer}");
            Console.WriteLine($"Wybór gracza to {wyborGracza}");

        }

        public static string Computer()
        {
            string[] Objects = { "Kamień", "Papier", "Nożyce" };

            Random n = new Random();
            int LosowanaLiczba = n.Next(0, Objects.Length);

            string AIchoice = Objects[LosowanaLiczba];
            Console.WriteLine(AIchoice);
            return AIchoice;
        }

        public static string Player(string choice)
        {
            Console.WriteLine("Witaj w grze Kamień-Papier-Nożyce.\nJaki jest twój wybór?\nK - Kamień\nP - Papier\nN - Nożyce");
            string WybranaRzecz = Console.ReadLine();
            switch (WybranaRzecz)
            {
                case "K":
                case "k":
                    choice = "Kamień";
                    break;
                case "P":
                case "p":
                    choice = "Papier";
                    break;
                case "N":
                case "n":
                    choice = "Nożyce";
                    break;
                default:
                    choice = "Error";
                    break;
            }
            return choice;
        }
           
        
        public static int Convertor()

        {
            string[] Objects = { "Kamień", "Papier", "Nożyce" };
            int moc1 = Array.IndexOf(Objects, "Kamień");
            int moc2 = Array.IndexOf(Objects, "Papier");
            int moc3 = Array.IndexOf(Objects, "Nożyce");
            return 0;
            

        }



    }
}
