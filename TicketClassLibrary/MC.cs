using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary
{
    public class MC : Vehicle
    {

        
        /// <summary>
        /// Constructor for MC
        /// </summary>
        /// <param name="licensePlate"></param>
        /// <param name="date"></param>
        public MC(string licensePlate, DateTime date): base(licensePlate, date) 
        {
        }
        
        //Metoder

        /// <summary>
        /// Prismetode for MC.price
        /// </summary>
        /// <returns>125</returns>
        public override double Price()
        {
            return 125.0;
        }


        /// <summary>
        /// Returns vehicletype string
        /// </summary>
        /// <returns>"MC"</returns>
        public override string VehicleType()
        {
            return "MC";
        }

    }
}
