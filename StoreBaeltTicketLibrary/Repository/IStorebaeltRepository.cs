
namespace StoreBaeltTicketLibrary.Repository
{
    public interface IStorebaeltRepository
    {
        void AddTicket(Ticket ticket);
        List<Ticket> GetTicketListByLicencePlate(string licensePlate);
        List<Ticket> GetTickets();
    }
}