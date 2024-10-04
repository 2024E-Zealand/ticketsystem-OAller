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
        /// Angiver om Brobizz anvendes for rabat.
        /// </summary>
        public bool HasBrobizz { get; set; }

        /// <summary>
        /// Returnerer prisen for at krydse broen. Skal implementeres i afledte klasser.
        /// </summary>
        /// <returns>Prisen som en double.</returns>
        public abstract double Price();

        /// <summary>
        /// Beregner prisen inklusive Brobizz rabat, hvis relevant.
        /// </summary>
        /// <returns>Den endelige pris som en double.</returns>
        public double CalculatePriceWithBrobizz()
        {
            double basePrice = Price();
            if (HasBrobizz)
            {
                return basePrice * 0.95; // 5% rabat
            }
            return basePrice;
        }

        /// <summary>
        /// Returnerer køretøjstypen. Skal implementeres i afledte klasser.
        /// </summary>
        /// <returns>En streng, der repræsenterer køretøjstypen.</returns>
        public abstract string VehicleType();
    }
}
