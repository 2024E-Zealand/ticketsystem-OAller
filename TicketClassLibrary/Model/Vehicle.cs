using System;

namespace TicketClassLibrary.Model
{
    /// <summary>
    /// Baseklasse for køretøjer, der krydser broen.
    /// </summary>
    public abstract class Vehicle
    {
        private string _licenseplate;

        /// <summary>
        /// Nummerpladen på køretøjet. Må ikke være længere end 7 tegn.
        /// </summary>
        public string Licenseplate
        {
            get { return _licenseplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentException("Nummerpladen må ikke være længere end 7 tegn.");
                }
                _licenseplate = value;
            }
        }

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
