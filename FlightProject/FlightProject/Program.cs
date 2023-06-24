using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject
{
    public class Program 
    {
        static void Main(string[] args)
        {

            FlightReservationSystem flightReservationSystem = new FlightReservationSystem();

            #region Flightlist

            flightReservationSystem.flightList = new List<Flight>()
            {
                new Flight()
                {
                    FlightNumber ="012",
                    DepartureCity = "Georgia",
                    ArrivalCity = "California",
                    DepartureTime = new DateTime(2023,11,5, 1,30, 00),
                    FullSeats = 50,
                    AvailableSeats = 22,
                    Distance = 769,
                    Price = 1250,

                },

                new Flight()
                {
                    FlightNumber ="013",
                    DepartureCity = "Georgia",
                    ArrivalCity = "Los Angeles",
                    DepartureTime = new DateTime(2023,11,5, 1,30, 00),
                    FullSeats = 60,
                    AvailableSeats = 16,
                    Distance = 623,
                    Price = 950,

                },

                new Flight()
                {
                    FlightNumber ="014",
                    DepartureCity = "Georgia",
                    ArrivalCity = "Madrid",
                    DepartureTime = new DateTime(2023,11,5, 6,15, 00),
                    FullSeats = 52,
                    AvailableSeats = 13,
                    Distance = 423,
                    Price = 750,
                },

                new Flight()
                {
                    FlightNumber ="015",
                    DepartureCity = "Georgia",
                    ArrivalCity = "Madrid",
                    DepartureTime = new DateTime(2023,8,8, 3,45,00),
                    FullSeats = 52,
                    AvailableSeats = 13,
                    Distance = 423,
                    Price = 750,
                },

                new Flight()
                {
                    FlightNumber ="016",
                    DepartureCity = "Georgia",
                    ArrivalCity = "Madrid",
                    DepartureTime = new DateTime(2023,10,2, 1,30, 00),
                    FullSeats = 52,
                    AvailableSeats = 13,
                    Distance = 423,
                    Price = 750,
                },

                new Flight()
                {
                    FlightNumber ="017",
                    DepartureCity = "Georgia",
                    ArrivalCity = "Madagascar",
                    DepartureTime = new DateTime(2023,11,5, 1,30, 00),
                    FullSeats = 45,
                    AvailableSeats = 10,
                    Distance = 723,
                    Price = 1050,

                },

            };


            foreach (var item in flightReservationSystem)
            {
                Console.WriteLine(item);
            }

#endregion


            Console.WriteLine("\n");

            // Search Flight Method
            flightReservationSystem.SearchFlights();


            Console.WriteLine("\n");


            #region Reservationlist

            flightReservationSystem.reservationList = new List<Reservation>()
            {
                new Reservation()
                {
                    ReservationNumber = "01",
                    PassengerName = "Lado",
                    flight = flightReservationSystem.flightList[1],
                },

                new Reservation()
                {
                    ReservationNumber = "02",
                    PassengerName = "jemali",
                    flight = flightReservationSystem.flightList[3],
                }

            };

            foreach(var item in flightReservationSystem.reservationList)
            {
                Console.WriteLine(item);
            }

            #endregion


            Console.WriteLine("\n");


            //Buy Method
            flightReservationSystem.BuyMethod();



            //Cancel Method
            flightReservationSystem.qustion();
        }
    }
}
