using System.Collections.Generic;
using TicketClassLibrary.Model;

namespace StoreBaeltsTicketLibrary
{
    /// <summary>
    /// Interface for Storebæltsbroens billet repository.
    /// </summary>
    public interface IStoreBaeltTicketsRepository
    {
        /// <summary>
        /// Tilføjer (køber) en ny billet.
        /// </summary>
        void AddTicket(Vehicle ticket);

        /// <summary>
        /// Returnerer alle billetter.
        /// </summary>
        List<Vehicle> GetAllTickets();

        /// <summary>
        /// Returnerer alle billetter for en specifik nummerplade.
        /// </summary>
        List<Vehicle> GetTicketsByLicensePlate(string licensePlate);
    }
}
