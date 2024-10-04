using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
using TicketClassLibrary.Model;
using System;

namespace TicketClassLibrary.MSTests
{
    [TestClass]
    public class StoreBaeltTicketsRepositoryTests
    {
        private StoreBaeltTicketsRepository _repository;

        [TestInitialize]
        public void Setup()
        {
            _repository = new StoreBaeltTicketsRepository();
            StoreBaeltTicketsRepository.ClearTickets(); // Nulstil før hver test
        }

        [TestMethod]
        public void AddTicket_ShouldAddTicketToRepository()
        {
            // Arrange
            var car = new Car
            {
                Licenseplate = "ABC123",
                Date = DateTime.Now
            };

            // Act
            _repository.AddTicket(car);

            // Assert
            var tickets = _repository.GetAllTickets();
            Assert.AreEqual(1, tickets.Count);
            Assert.AreEqual("ABC123", tickets[0].Licenseplate);
        }

        [TestMethod]
        public void GetAllTickets_ShouldReturnAllTickets()
        {
            // Arrange
            var car1 = new Car { Licenseplate = "ABC123", Date = DateTime.Now };
            var car2 = new Car { Licenseplate = "DEF456", Date = DateTime.Now };

            _repository.AddTicket(car1);
            _repository.AddTicket(car2);

            // Act
            var tickets = _repository.GetAllTickets();

            // Assert
            Assert.AreEqual(2, tickets.Count);
        }

        [TestMethod]
        public void GetTicketsByLicensePlate_ShouldReturnCorrectTickets()
        {
            // Arrange
            var car1 = new Car { Licenseplate = "ABC123", Date = DateTime.Now };
            var car2 = new Car { Licenseplate = "DEF456", Date = DateTime.Now };
            var car3 = new Car { Licenseplate = "ABC123", Date = DateTime.Now };

            _repository.AddTicket(car1);
            _repository.AddTicket(car2);
            _repository.AddTicket(car3);

            // Act
            var tickets = _repository.GetTicketsByLicensePlate("ABC123");

            // Assert
            Assert.AreEqual(2, tickets.Count);
            Assert.IsTrue(tickets.TrueForAll(t => t.Licenseplate == "ABC123"));
        }
    }
}
