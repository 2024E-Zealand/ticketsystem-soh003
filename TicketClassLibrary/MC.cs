using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC
    {

        //instansfelter
        private string _licensePlate;
        private DateTime _date;

        //properties
        public string Licenseplate
        {
            get { return _licensePlate; }
            set { _licensePlate = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }


        /// <summary>
        /// Constructor for MC
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public MC(string licensePlate, DateTime date)
        {
            _licensePlate = licensePlate;
            _date = date;
        }




        //Metoder

        /// <summary>
        /// Prismetode for MC.price
        /// </summary>
        /// <returns>125</returns>
        public double Price()
        {
            return 125.0;
        }


        /// <summary>
        /// Returns vehicletype string
        /// </summary>
        /// <returns>"MC"</returns>
        public string VehicleType()
        {
            return "MC";
        }

    }
}
