﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime FlightDate { get; set;}
        public DateTime EffectiveArrival{ get; set;}
        public int EstimatedDuration { get;set;}
        public Plane Plane { get; set; }    

        public ICollection<Passenger> Passenger { get; set; }

        public override string ToString()
        {
            return "Fligth Id " + FlightId + " Destination " + Destination
                + " Departure " + Departure + " FlightDate " + FlightDate + " EffectiveArrival " + EffectiveArrival
                + " EstimatedDuration " + EstimatedDuration;
        }

    }
}
