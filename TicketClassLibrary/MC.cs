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
        public MC(string licensePlate, DateTime date, bool brobizz = false): base(licensePlate, date) 
        {
            Brobizz = brobizz;
        }
        
        //Metoder

        /// <summary>
        /// Prismetode for MC.price
        /// </summary>
        /// <returns>125</returns>
        
        public override double Price()
        {
            double basePrice = 125.0;
            return ApplyBrobizzDiscount(basePrice);//her gør vi brug af rabatmetode fra baseklassen
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
