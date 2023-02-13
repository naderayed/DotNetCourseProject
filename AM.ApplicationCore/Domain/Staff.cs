using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Staff:Passenger
    {
        public DateTime EmployementDate {get;set;}
        public String Function { get;set;}  
        public int Salary { get;set;}

        public override string ToString()
        {
            return "EmployementDate" + EmployementDate + " Function " + Function
                + " Salary " + Salary;
        }
        public override void passengerType()
        {

            base.passengerType();
            Console.WriteLine(", I am a Staff");
        }
    }
    
 
}
