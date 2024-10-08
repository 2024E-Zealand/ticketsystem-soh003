﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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


        /// <summary>
        /// Initialiserer et Car-objekt før hver testmetode.
        /// </summary>
        [TestInitialize]
        public void Init()
        {
            //Arrange
            car = new Car("ABC123", DateTime.Now);
        }


        
        /// <summary>
        /// Tester at prismetoden returnerer det forventede
        /// </summary>
        [TestMethod]
        
        public void PriceTest_Ok()
        {

            // Act
            double price = car.Price();

            // Assert
            Assert.AreEqual(240.0, price);
        }

        /// <summary>
        /// Tester at prismetoden kun kan sættes til 240
        /// </summary>
        /// <param name="test_Pris"></param>
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


        //BrobizzRabat test her
        [TestMethod]
        public void Rabat_Ok()
        {
            //Arrange
            var carWithBrobizz = new Car("ABC1234", DateTime.Now, true);

            //Act
            double price = carWithBrobizz.Price();

            //Assert
            double expectedPrice = 240.0 * 0.95;
            Assert.AreEqual(expectedPrice, price);
        }


        /// <summary>
        /// Tester at tyoe sættes til Car
        /// </summary>
        [TestMethod]
        public void VehicleType_Ok()
        {
            //Arrange

            //Act

            string vehicleType = car.VehicleType();

            //Assert

            Assert.AreEqual("Car", vehicleType);
        }

        /// <summary>
        /// tester at type kun kan være car
        /// </summary>
        [TestMethod]
        public void VehicleType_NotOk()
        {
            //Arrange

            //Act

            string vehicleType = car.VehicleType();

            //Assert

            Assert.AreNotEqual("Truck", vehicleType);
        }

        /// <summary>
        /// Tester her om validation af licenseplate kan oprette med mere end 7 karakterer
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void CarInstans_NotOk()
        {
            //Arrange & Act
            var car = new Car("12345678", DateTime.Now);
        }



    }
}