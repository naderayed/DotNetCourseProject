using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interface
{
    public interface IflightMethods
    {
        List<DateTime> GetFlightDates(string destination);
        void GetFlight(string destination,string filterval);
        void ShowFlightDetails(Plane plane);
    }
}
