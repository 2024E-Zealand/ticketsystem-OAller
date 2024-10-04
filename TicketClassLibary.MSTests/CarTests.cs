using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.Model;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void Price_ShouldReturnFixedPrice()
        {
            // Arrange
            var car = new Car();

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240.0, price);
        }

        [TestMethod]
        public void VehicleType_ShouldReturnCar()
        {
            // Arrange
            var car = new Car();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        public void Licenseplate_ShouldStoreAndReturnLicenseplate()
        {
            // Arrange
            var car = new Car();
            string expectedLicenseplate = "AB12345";

            // Act
            car.Licenseplate = expectedLicenseplate;

            // Assert
            Assert.AreEqual(expectedLicenseplate, car.Licenseplate);
        }

        [TestMethod]
        public void Date_ShouldStoreAndReturnDate()
        {
            // Arrange
            var car = new Car();
            DateTime expectedDate = new DateTime(2024, 10, 4);

            // Act
            car.Date = expectedDate;

            // Assert
            Assert.AreEqual(expectedDate, car.Date);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Licenseplate_ShouldThrowException_WhenLongerThan7Characters()
        {
            // Arrange
            var car = new Car();

            // Act
            car.Licenseplate = "ABCDEFGH"; // Dette er 8 tegn, hvilket bør kaste en undtagelse.
        }

        [TestMethod]
        public void CalculatePriceWithBrobizz_ShouldReturnPriceWithDiscount()
        {
            // Arrange
            var car = new Car
            {
                HasBrobizz = true // Brobizz anvendes
            };

            // Act
            double discountedPrice = car.CalculatePriceWithBrobizz();

            // Assert med delta på grund af små forskelle i floating-point beregninger
            Assert.AreEqual(240.0 * 0.95, discountedPrice, 0.01);
        }
    }
}
