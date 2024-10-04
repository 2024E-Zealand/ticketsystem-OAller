using TicketClassLibrary.Model;
using System;

namespace OresundTicketLibrary
{
    /// <summary>
    /// Specifik klasse til biler, der krydser Øresundsbron.
    /// </summary>
    public class OresundCar : Car
    {
        /// <summary>
        /// Returnerer prisen for at krydse Øresundsbron.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public override double Price()
        {
            // Hvis Brobizz anvendes, reduceres prisen til 161 DKK
            if (HasBrobizz)
            {
                return 161.0;
            }
            return 410.0; // Standardpris uden Brobizz
        }

        /// <summary>
        /// Returnerer køretøjstypen som en streng.
        /// </summary>
        /// <returns>"Oresund car"</returns>
        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
