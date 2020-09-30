using System;
using System.Collections.Generic;
using System.Text;

namespace GameLibrary
{
    public class Player
    {
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public string Destination { get; set; }
        public string PreferedAirline { get; set; }
        public string TicketNumber { get; set; }
        public Player()
        {
            PlayerName = "";
            Age = 1;
            Destination = "";
            PreferedAirline = "";
            TicketNumber = "";
        }
    }
}
