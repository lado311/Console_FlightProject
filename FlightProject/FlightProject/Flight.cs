using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject
{
    public class Flight : FlightReservationSystem
    {
        public string FlightNumber { get; set; }
        public string DepartureCity { get; set; }
        public string ArrivalCity { get; set; }
        public DateTime DepartureTime { get; set; }
        public int FullSeats { get; set; }
        public int AvailableSeats { get; set; }
        public int Distance { get; set; }
        public int Price { get; set; }



        public override string ToString()
        {
            return $"Flight Number: {FlightNumber} , Departure: {DepartureCity} , Arrival: {ArrivalCity} , Flight Time: {DepartureTime} , Full Seats: {FullSeats} , Available seats:  {AvailableSeats} , Distance: {Distance} Miles , Price: {Price}$";
        }






    }
}
