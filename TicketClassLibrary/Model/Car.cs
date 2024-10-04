using System;

namespace TicketClassLibrary.Model
{
    /// <summary>
    /// Repræsenterer en bil, som krydser broen.
    /// </summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Returnerer den faste pris for at krydse broen.
        /// </summary>
        /// <returns>Prisen som en double (240 DKK).</returns>
        public override double Price()
        {
            return 240.0;
        }

        /// <summary>
        /// Returnerer køretøjstypen som en streng.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}
