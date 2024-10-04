using TicketClassLibrary.Model;
using System;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Specifik klasse til motorcykler, der krydser Øresundsbron.
    /// </summary>
    public class OresundMC : MC
    {
        /// <summary>
        /// Returnerer prisen for at krydse Øresundsbron.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public override double Price()
        {
            // Hvis Brobizz anvendes, reduceres prisen til 73 DKK
            if (HasBrobizz)
            {
                return 73.0;
            }
            return 210.0; // Standardpris uden Brobizz
        }

        /// <summary>
        /// Returnerer køretøjstypen som en streng.
        /// </summary>
        /// <returns>"Oresund MC"</returns>
        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
