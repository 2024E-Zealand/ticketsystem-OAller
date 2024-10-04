using System;

namespace TicketClassLibrary.Model
{
    /// <summary>
    /// Baseklasse for køretøjer, der krydser broen.
    /// </summary>
    public abstract class Vehicle
    {
        /// <summary>
        /// Nummerpladen på køretøjet.
        /// </summary>
        public string Licenseplate { get; set; }

        /// <summary>
        /// Dato for krydsning.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Returnerer prisen for at krydse broen. Skal implementeres i afledte klasser.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public abstract double Price();

        /// <summary>
        /// Returnerer køretøjstypen. Skal implementeres i afledte klasser.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public abstract string VehicleType();
    }
}

