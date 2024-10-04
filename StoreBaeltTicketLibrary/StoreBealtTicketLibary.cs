using System;
using System.Collections.Generic;
using TicketClassLibrary.Model;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Repository klasse for håndtering af Storebæltsbroen billetter.
    /// </summary>
    public class StoreBaeltTicketRepository
    {
        // Statisk liste til at holde alle billetter
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
    }
}
