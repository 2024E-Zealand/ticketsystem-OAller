using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundTicketLibrary;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class OresundTicketTests
    {
        [TestMethod]
        public void Price_ShouldBe410ForOresundCarWithoutBrobizz()
        {
            // Arrange
            var car = new OresundCar
            {
                HasBrobizz = false
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(410.0, price, 0.01);
        }

        [TestMethod]
        public void Price_ShouldBe161ForOresundCarWithBrobizz()
        {
            // Arrange
            var car = new OresundCar
            {
                HasBrobizz = true
            };

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(161.0, price, 0.01);
        }

        [TestMethod]
        public void Price_ShouldBe210ForOresundMCWithoutBrobizz()
        {
            // Arrange
            var mc = new OresundMC
            {
                HasBrobizz = false
            };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(210.0, price, 0.01);
        }

        [TestMethod]
        public void Price_ShouldBe73ForOresundMCWithBrobizz()
        {
            // Arrange
            var mc = new OresundMC
            {
                HasBrobizz = true
            };

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(73.0, price, 0.01);
        }

        [TestMethod]
        public void VehicleType_ShouldReturnOresundCar()
        {
            // Arrange
            var car = new OresundCar();

            // Act
            string vehicleType = car.VehicleType();

            // Assert
            Assert.AreEqual("Oresund car", vehicleType);
        }

        [TestMethod]
        public void VehicleType_ShouldReturnOresundMC()
        {
            // Arrange
            var mc = new OresundMC();

            // Act
            string vehicleType = mc.VehicleType();

            // Assert
            Assert.AreEqual("Oresund MC", vehicleType);
        }
    }
}
