using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace StoreBaeltTicketLibrary
{
    internal class StoreBaelt
    {
        public double StoreBaeltPrice(Vehicle v)
        {
            
            double finalPrice = v.Price();

            // Apply the weekend discount for Cars only
            if (v.VehicleType() == "Car" && (v.Date.DayOfWeek == DayOfWeek.Saturday || v.Date.DayOfWeek == DayOfWeek.Sunday))
            {
                finalPrice *= 0.8; // 20% weekend discount
            }

            // Apply Brobizz discount after the weekend discount
            if (v.Brobizz)
            {
                finalPrice *= 0.95; //  5% Brobizz discount
            }

            return finalPrice;
        }
    }
}
