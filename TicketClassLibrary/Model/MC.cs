using System;

namespace TicketClassLibrary.Model
{
    /// <summary>
    /// Repræsenterer en motorcykel (MC), som krydser broen.
    /// </summary>
    public class MC
    {
        /// <summary>
        /// Nummerpladen på motorcyklen.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Dato for krydsning.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer den faste pris for at krydse broen.
        /// </summary>
        /// <returns>Prisen som en double (125 DKK).</returns>
        public double Price()
        {
            return 125.0;
        }

        /// <summary>
        /// Returnerer køretøjstypen som en streng.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public string VehicleType()
        {
            return "MC";
        }
    }
}

