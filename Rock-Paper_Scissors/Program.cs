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
            string[] Objects = { "Kamień", "Papier", "Nożyczki" };


            Random n = new Random();
            int LosowanaLiczba = n.Next(0, Objects.Length);

            string AIchoice = Objects[LosowanaLiczba];
            Console.WriteLine(AIchoice);
            return AIchoice;
         }

        public static string Player()
        {
            Console.WriteLine("Witaj w grze Kamień-Papier-Nożyce.\nJaki jest twój wybór?\nK - Kamien\nP - Papier\nN - Nożyce");
            string WybranaRzecz = Console.ReadLine();
            if (WybranaRzecz == "K" || WybranaRzecz == "k")
            {
                string choice = "Kamień";
                return choice;
            }
            else if (WybranaRzecz == "P" || WybranaRzecz == "p")
            {
                string choice = "Papier";
                return choice;
            }
            else if (WybranaRzecz == "N" || WybranaRzecz == "n")
            {
                string  choice = "Nożyce";
                return choice;
            }
            return "sds"; 
        
        }










        
            
    }
}
