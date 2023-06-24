using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject
{
    public class Reservation : FlightReservationSystem
    {
        public string ReservationNumber { get; set; }
        public string PassengerName { get; set; }
        public Flight flight { get; set; }


        public override string ToString()
        {
            return $"Reservation Number: {ReservationNumber} , Passenger Name: {PassengerName} , Flight Detail: {flight}";
        }


    }
}
