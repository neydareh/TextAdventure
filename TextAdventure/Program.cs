using System;

namespace TextAdventure
{
    public class Program
    {
        
        public static void Main(string[] args)
        {
            StartGame();
        }

        #region StartGame
        public static void StartGame()
        {
            Game game = new Game();
            game.PlayerName = Greeting();
            int choice = Option(game.PlayerName);
            Console.WriteLine(game.GetDestination(choice));
        }
        #endregion

        #region Greeting
        public static string Greeting()
        {
            Console.WriteLine("Hey there! Welcome to Travel Text Adventure!!");
            Console.Write("What's your name: ");
            string playerName = Console.ReadLine();

            return playerName;
        }
        #endregion

        #region Option
        public static int Option(string playerName)
        {
            int choice = 0;
            Console.WriteLine($"Hello {playerName}");
            Console.WriteLine("Where would you like to travel to? (1) Somewhere (2) Nowhere");
            choice = int.Parse(Console.ReadLine());

            while (choice != 1 || choice != 2)
            {
                if (choice == 1 || choice == 2)
                {
                    break;
                }
                Console.WriteLine("Where would you like to travel to? (1) Somewhere (2) Nowhere");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
        #endregion
    }
}
