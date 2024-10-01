using Microsoft.VisualStudio.TestTools.UnitTesting;
using OresundbronTicketLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketClassLibrary;

namespace OresundbronTicketLibrary.Tests
{
    [TestClass()]
    public class OresundTests
    {
        //Test price for car uden brobizz
        [TestMethod]
        public void Oresund_RegularCarPrice()
        {
            // Arrange
            var vehicle = new Car ("ABC1234", DateTime.Now, false);//Instans car uden brobizz
            var oresund = new Oresund();

            // Act
            double price = oresund.OresundPrice(vehicle);

            // Assert
            Assert.AreEqual(410, price);
        }

        //Test price for car med brobizz
        [TestMethod]
        public void Oresund_BrobizzCarPrice()
        {
            // Arrange
            var vehicle = new Car("ABC1234", DateTime.Now, true);//Instans car med brobizz
            var oresund = new Oresund();

            // Act
            double price = oresund.OresundPrice(vehicle);

            // Assert
            Assert.AreEqual(161, price);
        }

        //Test price for MC uden brobizz
        [TestMethod]
        public void Oresund_RegularMCPrice()
        {
            // Arrange
            var vehicle = new MC("ABC1234", DateTime.Now, false); //Instans MC uden brobizz
            var oresund = new Oresund();

            // Act
            double price = oresund.OresundPrice(vehicle);

            // Assert
            Assert.AreEqual(210, price);
        }

        //Test price for MC med brobizz
        [TestMethod]
        public void Oresund_BrobizzMCPrice()
        {
            // Arrange
            var vehicle = new MC("ABC1234", DateTime.Now, true);//Instans MC med brobizz
            var oresund = new Oresund();

            // Act
            double price = oresund.OresundPrice(vehicle);

            // Assert
            Assert.AreEqual(73, price);
        }
    }
}