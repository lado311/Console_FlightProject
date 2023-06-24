using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightProject
{
    public class FlightReservationSystem : IEnumerable
    {
        public List<Flight> flightList { get; set; }
        public List<Reservation> reservationList { get; set; }
        public int UserBalance { get; set; } = 2000;

        public IEnumerator GetEnumerator()
        {
            return flightList.GetEnumerator();
        }



        #region Searchflight

        public void SearchFlights()
        {

            Console.WriteLine("Enter Departure Country: ");
            string departureCity = Console.ReadLine();

            Console.WriteLine("Enter Arrival Country: ");
            string arrivalCity = Console.ReadLine();

            for (int i = 0; i < flightList.Count; i++)
            {

                if (departureCity != flightList[i].DepartureCity && arrivalCity != flightList[i].ArrivalCity)
                {

                    Console.WriteLine("No flights were found with such names.");
                    break;

                }



                if (departureCity == flightList[i].DepartureCity && arrivalCity == flightList[i].ArrivalCity)
                {

                    Console.WriteLine(flightList[i]);

                }
                
            }

        }

        #endregion


        #region buymethod
        public void BuyMethod()
        {
            Console.Write("Select which direction you want to Choose: ");
            int ChooseDirection = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine($"User Balance: {UserBalance}$");

            Console.Write("Enter how many tickets you want to Buy: ");
            int ChooseSeats = int.Parse(Console.ReadLine());

            
            for (int i = 0;i < reservationList.Count;i++)
            {
                if (ChooseDirection == i + 1 && UserBalance >= ChooseSeats * reservationList[i].flight.Price && ChooseSeats < reservationList[i].flight.AvailableSeats)
                {
                    UserBalance -= (ChooseSeats * reservationList[i].flight.Price);
                    Console.WriteLine($"remaining balance: {UserBalance}$");

                    reservationList[i].flight.AvailableSeats -= ChooseSeats;
                    Console.WriteLine($"There are {reservationList[i].flight.AvailableSeats} seats left in this direction");

                }

                else if (ChooseDirection == i + 1 && ChooseSeats > reservationList[i].flight.AvailableSeats)
                {
                    Console.WriteLine("We have no more seats in this direction.");
                }

                else if (ChooseDirection == i + 1 && UserBalance < ChooseSeats * reservationList[i].flight.Price)
                {
                    Console.WriteLine("You have not enough Money on your balance.");
                }

            
            }

        }
        #endregion


        #region CancelReservation



        public void qustion()
        {
            Console.WriteLine("\n");

            Console.Write("If you want to Cancel any direction, write yes, otherwise write no: ");
            string Answer = Console.ReadLine();

            if (Answer == "yes")
            {
                CancelReservation();

            }
            else if(Answer == "no")
            {
                Console.WriteLine("The reservation was made successfully.");
            }



        }





        public void CancelReservation()
        {
            Console.WriteLine("\n");


            Console.Write("Enter the direction you want to Cancel: ");
            int ChooseDirectCancel = int.Parse(Console.ReadLine());

            for (int i = 0; i < reservationList.Count; i++)
            {         
                

                if (ChooseDirectCancel == (i + 1))
                {
                    Console.WriteLine($"Cancel bookings:\n {reservationList[i]}");
                    reservationList.Remove(reservationList[i]);

                    break;
                }

                Console.WriteLine($"Remaining bookings:\n {reservationList[i]}");
            }





        }


        #endregion


    }
}
