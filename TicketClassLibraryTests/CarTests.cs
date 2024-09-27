using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.ConstrainedExecution;

namespace TicketClassLibrary.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car car; 

        [TestInitialize]
        public void Init()
        {
            //Arrange
            car = new Car("ABC123", DateTime.Now);
        }


        [TestMethod]

        public void PriceTest_Ok()
        {

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240.0, price);
        }


        [TestMethod]
        [DataRow(239.0)]
        [DataRow(241.0)]
        public void PriceTest_NotOk(double test_Pris)
        {

            // Act
            double price = car.Price();

            //Assert

            Assert.AreNotEqual(test_Pris, price);


        }

        [TestMethod]
        public void VehicleType_Ok()
        {
            //Arrange

            //Act

            string vehicleType = car.VehicleType();

            //Assert

            Assert.AreEqual("Car", vehicleType);
        }

        [TestMethod]
        public void VehicleType_NotOk()
        {
            //Arrange

            //Act

            string vehicleType = car.VehicleType();

            //Assert

            Assert.AreNotEqual("Truck", vehicleType);
        }





    }
}