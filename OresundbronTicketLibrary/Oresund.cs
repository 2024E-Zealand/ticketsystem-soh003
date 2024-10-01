using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundbronTicketLibrary
{
    public class Oresund
    {
        /// <summary>
        /// beregner pris for at passere øresund
        /// afhængig af MC eller Car og der tages højde for Brobizz
        /// </summary>
        /// <param name="v">køretøjet der beregnes pris for</param>
        /// <returns>final price baseret på type vehicle og brobizz status</returns>
        public double OresundPrice(Vehicle v)
        {
            double finalPrice = 0;

            if (v.VehicleType() == "Car")
            {
                if (v.Brobizz)
                {
                    finalPrice = 161;//Brobizz price car
                }
                else
                {
                    finalPrice = 410;// regular price car          

                 
                }
            }
            else if (v.VehicleType() == "MC")
            {
                if (v.Brobizz)
                {
                    finalPrice = 73;//Brobizz price MC
                }
                else
                {
                    finalPrice = 210;//regular price MC
                }
            }

            return finalPrice;
        }


        /// <summary>
        /// returnerer type af vehicle for øresund
        /// </summary>
        /// <param name="v">vihicle der bliver identificeret som MC eller Car</param>
        /// <returns>String af typen vehicle ("Oresund Car" eller "Oresund MC"), Alternativt unknown vehicle</returns>
        public string OresundTypeVehicle(Vehicle v)
        {
            if (v.VehicleType() == "Car")
            {
                
                return "Oresund car";

            }
            else if(v.VehicleType() == "MC")
            {
                
                return "Oresund MC";

            }
            return "Unknown Type Of vehicle";
        }



    }
}
