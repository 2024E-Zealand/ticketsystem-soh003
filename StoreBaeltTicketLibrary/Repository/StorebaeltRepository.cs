using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreBaeltTicketLibrary.Repository
{
    public class StorebaeltRepository : IStorebaeltRepository
    {
        //Statisk liste til at holde alle billetter
        private static List<Ticket> tickets = new List<Ticket>();

        //Tilføjer en ny ticket(Køber en ticket)
        /// <summary>
        /// Tilføjer en ny ticket
        /// </summary>
        /// <param name="ticket">Den ticket der tilføjes</param>
        public void AddTicket(Ticket ticket)
        {
            tickets.Add(ticket);
        }

        //GetAll Tickets
        /// <summary>
        /// Returnerer en liste af alle tickets
        /// </summary>
        /// <returns>Liste af alle tickets</returns>
        public List<Ticket> GetTickets()
        {
            return tickets;
        }


        /// <summary>
        /// Returnerer liste af tickets for LicensePlate
        /// </summary>
        /// <param name="licensePlate">Licenseplate for søgning</param>
        /// <returns>Liste af tickets med tilknyttet licenseplate</returns>
        public List<Ticket> GetTicketListByLicencePlate(string licensePlate)
        {
            return tickets.Where(t => t.LicensePlate == licensePlate).ToList();
        }

    }

}