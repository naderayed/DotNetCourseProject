using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Traveller:Passenger
    {
        public string HealthInformation { get; set; }
        public String Nationality { get; set; }

        public override void passengerType()
        {

            base.passengerType();
            Console.WriteLine(", I am a Traveller");
        }
        public override string ToString()
        {
            return "HealthInformation" + HealthInformation + " Nationality " + Nationality;

        }
    }
  
}
