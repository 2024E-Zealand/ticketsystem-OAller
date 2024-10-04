using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class StoreBaeltTicketTests
    {
        [TestMethod]
        public void Price_ShouldApplyWeekendDiscountWithoutBrobizz()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 5), // En lørdag
                HasBrobizz = false
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0 * 0.8, price, 0.01); // 20% rabat
        }

        [TestMethod]
        public void Price_ShouldApplyWeekendAndBrobizzDiscount()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 5), // En lørdag
                HasBrobizz = true
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0 * 0.8 * 0.95, price, 0.01); // 20% weekendrabat efterfulgt af 5% Brobizz-rabat
        }

        [TestMethod]
        public void Price_ShouldApplyBrobizzDiscountOnWeekdays()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 2), // En onsdag
                HasBrobizz = true
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0 * 0.95, price, 0.01); // Kun 5% Brobizz-rabat
        }

        [TestMethod]
        public void Price_ShouldNotApplyDiscountOnWeekdaysWithoutBrobizz()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 2), // En onsdag
                HasBrobizz = false
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0, price, 0.01); // Ingen rabatter
        }
    }
}
