using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class Car : Vehicle
    {
        

        //Constructor
        /// <summary>
        /// Constructor til instancer af car med properties LicentePlate og date
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        public Car(string licensePlate, DateTime date): base(licensePlate, date)
        {
           
        }

        // Methoder
        /// <summary>
        /// Prismetode for car.price
        /// </summary>
        /// <returns> 240 </returns>
        public override double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// VehicleType metode for car.VehicleType
        /// </summary>
        /// <returns> Car </returns>
        public override string VehicleType()
        {
            return "Car";
        }





    }
}
