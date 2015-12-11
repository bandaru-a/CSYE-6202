using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation.Model
{
    public class Ticket
    {
        public string FlightId { get; set; }

        public string TicketId { get; set; }

        public DateTime BookedOn { get; set; }

        public string Fightclass { get; set; }

        public string BookedBy { get; set; }
    }
}
