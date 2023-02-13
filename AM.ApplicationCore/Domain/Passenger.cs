using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
          public int PassportNumber { get; set; }   
        public string EmailAddress { get; set; }
        public string LastName { get; set;}
        public string FirstName { get; set;}
        public string TelNumber { get; set;}
        public ICollection<Flight> Flights { get; set; }

        //public Boolean checkProfile(string fname,string lname)
        //{
        //    return (fname.Equals(FirstName) && lname.Equals(LastName));
        //}
        public Boolean checkProfile(string fname, string lname, string? email = null)
        {
            if (email != null)
            {
                return (fname.Equals(FirstName) && lname.Equals(LastName));


            }
            return (fname.Equals(FirstName) && lname.Equals(LastName) && email.Equals(EmailAddress));
        }

        public virtual void passengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
        public override string ToString()
        {
            return "Passenger" + FirstName + " " + LastName + " PassportNumber " + PassportNumber
                + " TelNumber " + TelNumber;
        }
    }
}
