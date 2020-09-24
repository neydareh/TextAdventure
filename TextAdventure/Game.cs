using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    public class Game
    {
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public List<string> Locations { get; set; }

        public string GetDestination(int choice)
        {
            string destination = "";
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Please enter your destination");
                    destination = Console.ReadLine();
                    break;
                case 2:
                    destination = GetRandomDestination();
                    break;
                default:
                    break;
            }
            return $"{destination}";
        }

        private string GetRandomDestination()
        {
            string[] destinations = {"Brazil", "England", "Australia", "Belgium", "Canada", "Argentina", "Finland"};
            return $"{destinations[new Random().Next(0, 6)]}";
        }

        public Game()
        {
        }
    }
}
