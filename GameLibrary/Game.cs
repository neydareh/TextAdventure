using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Game
    {
        public static List<Player> players = new List<Player>();


        public static void SavePlayer(Player player)
        {
            players.Add(player);
        }
        public static void DisplayAllPlayers(List<Player> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player: {player.PlayerName}");
            }
            Console.ReadLine();
            Console.Clear();
        }
        public static void DisplayPlayerStats(List<Player> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player: {player.PlayerName}");
                Console.WriteLine($"Player Airline: {player.PreferedAirline}");
                Console.WriteLine($"Ticket Number: {player.TicketNumber}");
                Console.WriteLine("");
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
