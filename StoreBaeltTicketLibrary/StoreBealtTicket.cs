using TicketClassLibrary.Model;
using System;

namespace StoreBaeltTicketLibrary
{
    /// <summary>
    /// Specifik billet til Storebæltsbroen med weekendrabat.
    /// </summary>
    public class StoreBaeltTicket : Car
    {
        /// <summary>
        /// Returnerer prisen for at krydse Storebæltsbroen med specifikke rabatter.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public override double Price()
        {
            double basePrice = base.Price();

            // Weekend rabat på 20% for Storebæltsbroen
            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
            {
                return basePrice * 0.8; // 20% rabat i weekenden
            }

            return basePrice;
        }
    }
}
