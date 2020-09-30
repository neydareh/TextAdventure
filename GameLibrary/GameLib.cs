using System;

namespace GameLibrary
{
    public static class GameLib
    {
        #region StartGame
        public static void StartGame()
        {
            Player playerOne = new Player();
            playerOne.PlayerName = Greeting();
            playerOne.Destination = GetDestination(Option(playerOne.PlayerName));
            playerOne.PreferedAirline = GetAirline(GenericOption());
            playerOne.TicketNumber = GenerateTicketNumber();
            SimulateBoarding();
        }
        #endregion

        #region Greeting
        private static string Greeting()
        {
            Console.WriteLine("Hey there! Welcome to Travel Text Adventure!!");
            Console.Write("What's your name: ");
            string playerName = Console.ReadLine();
            return playerName;
        }
        #endregion

        #region Option
        private static int Option(string playerName)
        {
            int choice = 0;
            Console.WriteLine($"Hello {playerName}");
            Console.WriteLine("Where would you like to travel to? (1) Somewhere (2) Nowhere");
            choice = int.Parse(Console.ReadLine());

            while (choice != 1 || choice != 2 )
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

        private static int GenericOption()
        {
            int choice = 0;

            Console.WriteLine("(1) Type in your airline (2) Pick a random airline: ");
            choice = int.Parse(Console.ReadLine());

            while (choice != 1 || choice != 2)
            {
                if (choice == 1 || choice == 2)
                {
                    break;
                }
                Console.WriteLine("(1) Type in your airline (2) Pick a random airline: ");
                choice = int.Parse(Console.ReadLine());
            }
            return choice;
        }
        #endregion

        #region GetDestination
        private static string GetDestination(int choice)
        {
            string destination = "";
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter your destination: ");
                    destination = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Press enter to generate a random destination");
                    Console.ReadLine();
                    destination = GetRandomDestination();
                    break;
                default:
                    break;
            }
            return $"{destination}";
        }
        #endregion

        #region GetAirline
        private static string GetAirline(int choice)
        {
            string airline = "";
            switch (choice)
            {
                case 1:
                    Console.Write("Please enter your prefered airline: ");
                    airline = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Press enter to choose a random airline");
                    Console.ReadLine();
                    airline = GetRandomAirline();
                    break;
                default:
                    break;
            }
            return $"{airline}";
        }
        #endregion

        #region GetRandomAirline
        private static string GetRandomAirline()
        {
            string[] destinations = { "American Airlines", "Spirit", "Southwest Airlines", "United Airlines", "Delta", "Alasaka Airlines", "Frontier Airlines" };
            return $"{destinations[new Random().Next(0, 6)]}";
        }
        #endregion

        #region GetRandomDestination
        private static string GetRandomDestination()
        {
            string[] destinations = { "Brazil", "England", "Australia", "Belgium", "Canada", "Argentina", "Finland" };
            return $"{destinations[new Random().Next(0, 6)]}";
        }
        #endregion

        #region GenerateTicketNumber
        private static string GenerateTicketNumber()
        {
            string ticketNumber = "FLIGHT-FLY-";
            Random rand = new Random();
            ticketNumber += $"{rand.Next(100, 200)}";
            return ticketNumber;
        }
        #endregion

        #region SimulateBoarding
        private static void SimulateBoarding()
        {
            Console.Clear();
            Console.WriteLine("                         ##");
            Console.WriteLine("                          #   #");
            Console.WriteLine("###                        #      #");
            Console.WriteLine("##  #                       #        #");
            Console.WriteLine("##   #                      #         # # # # # # # ");
            Console.WriteLine("##    # # # # # # # # # # #  #                        # ");
            Console.WriteLine("##                                                      # ");
            Console.WriteLine("##    # # # # # # # # # # #  #                        # ");
            Console.WriteLine("##  #                       #           # # # # # # # ");
            Console.WriteLine("## #                        #        #");
            Console.WriteLine("###                        #      #");
            Console.WriteLine("                          #   #");
            Console.WriteLine("                        ##");
            Console.ReadLine();
            Console.Clear();
            
        }
        #endregion

        #region SimulateTravel
        #endregion
    }
}
