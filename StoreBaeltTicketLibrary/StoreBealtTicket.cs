using TicketClassLibrary.Model;
using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Specifik billet til Storebæltsbroen med weekendrabat og Brobizz integration.
    /// </summary>
    public class StoreBaeltTicket : Car
    {
        /// <summary>
        /// Returnerer prisen for at krydse Storebæltsbroen med specifikke rabatter.
        /// Weekendrabat og derefter Brobizz-rabat anvendes i nævnte rækkefølge.
        /// </summary>
        /// <returns>Den endelige pris som en double.</returns>
        public override double Price()
        {
            double basePrice = base.Price();

            // Anvend weekendrabat, hvis det er lørdag eller søndag
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                basePrice *= 0.8; // 20% rabat i weekenden
            }

            // Anvend Brobizz-rabat efter weekendrabat, hvis Brobizz anvendes
            if (HasBrobizz)
            {
                basePrice *= 0.95; // 5% Brobizz rabat
            }

            return basePrice;
        }
    }
}
