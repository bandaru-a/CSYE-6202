using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation.Model
{
    public class Flights
    {
        public string FlightId { get; set; }
        
        public string FlightDescription { get; set; }
        
        public string Source { get; set; }
         
        public string Destination { get; set; }

        public DateTime ArrivalTime { get; set; }

        public DateTime DepTime { get; set; }
    }
}
