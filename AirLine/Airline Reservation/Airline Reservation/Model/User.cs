using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation.Model
{
    class User:Person
    {
        public string UserId
        {
            get;
            set;
        }
        
        public string email_Id
        {
            get;
            set;
        }

        public string Contact_No
        {
            get;
            set;
        }


        public string Password
        {
            get;
            set;
        }
        
        public string State
        {
            get;
            set;
        }


    }
}
