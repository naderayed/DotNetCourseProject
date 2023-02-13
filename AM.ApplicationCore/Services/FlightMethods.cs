using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethods : IflightMethods
    {
        public List<Flight> Flights { get; set; } = new List<Flight>();

        public void GetFlight(string filType, string filterval)
        {
            switch(filType)
            {
                case "Departure":
                    foreach(Flight flight in Flights) { 
                    if(flight.Departure.Equals(filterval))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;

                case "Destination":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.Destination.Equals(filterval))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "EstimatedDuration":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.EstimatedDuration==(int.Parse(filterval)))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                case "FlightDate":
                    foreach (Flight flight in Flights)
                    {
                        if (flight.FlightDate.Equals(DateTime.Parse(filterval)))
                        {
                            Console.WriteLine(flight);
                        }
                    }
                    break;
                default: Console.WriteLine("incorrect");
                    break;
            }
        }

        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> dates = new List<DateTime>();
            List<DateTime> dates2 = (from f in Flights
                                    where f.Destination.Equals(destination)
                                    select f.FlightDate).ToList();

            foreach (Flight flight in Flights) {
                if (flight.Destination.Equals(destination))
                {
                    dates.Add(flight.FlightDate);
                }
            }
            return dates2;
        }

        public void ShowFlightDetails(Plane plane)
        {
            var flights = from f in Flights
                                          where f.Plane == plane
                                          select new { f.FlightDate, f.Destination };
        }
    }
}
