using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class MCTests
    {
        private MC mc;


        /// <summary>
        /// Initialiserer et MC-objekt før hver testmetode.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            //Arrange
            mc = new MC("ABC123", DateTime.Now);
        }



        /// <summary>
        /// Tester at prismetoden returnerer det forventede
        /// </summary>
        [TestMethod]

        public void PriceTest_Ok()
        {

            // Act
            double price = mc.Price();

            // Assert
            Assert.AreEqual(125.0, price);
        }

        /// <summary>
        /// Tester at prismetoden kun kan sættes til 125
        /// </summary>
        /// <param name="test_Pris"></param>
        [TestMethod]
        [DataRow(124.0)]
        [DataRow(126.0)]
        public void PriceTest_NotOk(double test_Pris)
        {

            // Act
            double price = mc.Price();

            //Assert

            Assert.AreNotEqual(test_Pris, price);


        }

        /// <summary>
        /// Tester at Vehivletype sættes til MC
        /// </summary>
        [TestMethod]
        public void VehicleType_Ok()
        {
            //Arrange

            //Act

            string vehicleType = mc.VehicleType();

            //Assert

            Assert.AreEqual("MC", vehicleType);
        }

        /// <summary>
        /// tester at type kun kan være MC
        /// </summary>
        [TestMethod]
        public void VehicleType_NotOk()
        {
            //Arrange

            //Act

            string vehicleType = mc.VehicleType();

            //Assert

            Assert.AreNotEqual("Car", vehicleType);
        }
    }
}