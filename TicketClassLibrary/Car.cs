using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car
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

        //Constructor
        /// <summary>
        /// Constructor til instancer af car med properties LicentePlate og date
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date)
        {
            _licensePlate = licensePlate;
            _date = date;
        }

        // Methoder
        /// <summary>
        /// Prismetode for car.price
        /// </summary>
        /// <returns> 240 </returns>
        public double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// VehicleType metode for car.VehicleType
        /// </summary>
        /// <returns> Car </returns>
        public string VehicleType()
        {
            return "Car";
        }





    }
}
