using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class StoreBaeltTicketTests
    {
        [TestMethod]
        public void Price_ShouldApplyWeekendDiscount()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 5) // En lørdag
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0 * 0.8, price, 0.01);
        }

        [TestMethod]
        public void Price_ShouldNotApplyDiscountOnWeekdays()
        {
            // Arrange
            var ticket = new StoreBaeltTicket
            {
                Date = new DateTime(2024, 10, 2) // En onsdag
            };

            // Act
            double price = ticket.Price();

            // Assert
            Assert.AreEqual(240.0, price, 0.01);
        }
    }
}
