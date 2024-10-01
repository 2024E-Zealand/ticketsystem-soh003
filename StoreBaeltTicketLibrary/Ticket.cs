using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary
{
    public class Ticket
    {
        //Properties for ticket
        public string LicensePlate { get; set; }
        public string VehicleType { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        //konstructor
        public Ticket(string licensePlate, string vehicleType, DateTime date, double price)
        {
            LicensePlate = licensePlate;
            VehicleType = vehicleType;
            Date = date;
            Price = price;
        }
    }
}
