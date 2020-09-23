using System;

namespace TextAdventure
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static void StartGame()
        {
            int choice = 0;
            string playerName = Greeting();
            Option(playerName);
            Travel(choice);
        }

        private static string Greeting()
        {
            Console.WriteLine("Hey there! Welcome to Travel Text Adventure!!");
            Console.Write("What's your name: ");
            string playerName = Console.ReadLine();

            return playerName;
        }

        private static void Travel(int choice)
        {
            throw new NotImplementedException();
        }

        public static void Option(string playerName)
        {
            Console.WriteLine($"Hello {playerName}");
            Console.WriteLine("");
        }

    }
}
