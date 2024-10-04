using StoreBaeltsTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using TicketClassLibrary.Model;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository klasse for håndtering af Storebæltsbroens billetter.
    /// </summary>
    public class StoreBaeltTicketsRepository : IStoreBaeltTicketsRepository
    {
        // Statisk liste til at holde alle billetter for Storebæltsbroen.
        private static List<Vehicle> _tickets = new List<Vehicle>();

        /// <summary>
        /// Tilføjer (køber) en ny billet.
        /// </summary>
        /// <param name="ticket">Den nye billet, der skal tilføjes.</param>
        public void AddTicket(Vehicle ticket)
        {
            _tickets.Add(ticket);
        }

        /// <summary>
        /// Returnerer alle billetter.
        /// </summary>
        /// <returns>En liste over alle billetter.</returns>
        public List<Vehicle> GetAllTickets()
        {
            return _tickets;
        }

        /// <summary>
        /// Returnerer alle billetter for en specifik nummerplade.
        /// </summary>
        /// <param name="licensePlate">Nummerpladen for at finde billetter.</param>
        /// <returns>En liste over billetter for den specifikke nummerplade.</returns>
        public List<Vehicle> GetTicketsByLicensePlate(string licensePlate)
        {
            return _tickets.Where(ticket => ticket.Licenseplate == licensePlate).ToList();
        }

        /// <summary>
        /// Nulstiller listen over billetter. Bruges til testformål.
        /// </summary>
        public static void ClearTickets()
        {
            _tickets.Clear();
        }
    }
}
