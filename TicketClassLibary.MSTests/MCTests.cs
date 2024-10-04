using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary.Model;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class MCTests
    {
        [TestMethod]
        public void Price_ShouldReturnFixedPrice()
        {
            // Arrange
            var mc = new MC();

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(125.0, price);
        }

        [TestMethod]
        public void VehicleType_ShouldReturnMC()
        {
            // Arrange
            var mc = new MC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("MC", vehicleType);
        }

        [TestMethod]
        public void Licenseplate_ShouldStoreAndReturnLicenseplate()
        {
            // Arrange
            var mc = new MC();
            string expectedLicenseplate = "XY98765";

            // Act
            mc.Licenseplate = expectedLicenseplate;

            // Assert
            Assert.AreEqual(expectedLicenseplate, mc.Licenseplate);
        }

        [TestMethod]
        public void Date_ShouldStoreAndReturnDate()
        {
            // Arrange
            var mc = new MC();
            DateTime expectedDate = new DateTime(2024, 10, 5);

            // Act
            mc.Date = expectedDate;

            // Assert
            Assert.AreEqual(expectedDate, mc.Date);
        }
    }
}
