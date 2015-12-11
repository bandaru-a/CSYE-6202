using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation.Model
{
    public class FlightFare
    {
        public string FlightId { get; set; }

        public decimal Cost { get; set; }

        public string FlightClass { get; set; }       
    }
}
