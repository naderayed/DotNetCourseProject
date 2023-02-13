// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interface;
using AM.ApplicationCore.Services;

Console.WriteLine("Hello, World!");
Plane  Plane= new Plane();
Plane.Capacity = 100;
Plane plane2= new Plane { Capacity= 100 };
Console.WriteLine(plane2);
Passenger passenger = new Passenger { FirstName = "nader", LastName = "ayed", EmailAddress = "email@com" };
FlightMethods fe = new FlightMethods();
fe.Flights = TestData.listFlights;
Console.WriteLine("********TP2*******");
Console.WriteLine("********TP2*******GetFlightDates");
foreach (DateTime t in fe.GetFlightDates("Madrid"))
{
    Console.WriteLine(t);
};
Console.WriteLine("********TP2*******GetFlight");
fe.GetFlight("Destination", "Paris");
