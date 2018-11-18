using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarRentalSystem;

namespace UnitTestCarRentalSystem
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJourney()
        {
            // arrange
            Vehicle testVehicles = new Vehicle("Test Subject", "Mod-1", 2018, "TEST001", 3500, 3.5, 1000);

            // act
            testVehicles.Journey.AddKilometers(2);
            testVehicles.Journey.AddKilometers(5);
            testVehicles.Journey.AddKilometers(3.5);
            double jounery = testVehicles.Journey.Kilometers;

            // assert
            Assert.AreEqual(10.5, jounery);
        }

        [TestMethod]
        public void TestFuelPurchase()
        {
            // arrange
            Vehicle testVehicles = new Vehicle("Test Subject", "Mod-1", 2018, "TEST001", 3500, 3.5, 1000);

            // act
            testVehicles.FuelPurchase.PurchaseFuel(1.5, 15);
            testVehicles.FuelPurchase.PurchaseFuel(1, 10);
            testVehicles.FuelPurchase.PurchaseFuel(2.5, 25);
            double fuelEconomy = testVehicles.FuelPurchase.FuelEconomy;
            double litres = testVehicles.FuelPurchase.Litres;
            double cost = testVehicles.FuelPurchase.Cost;

            // assert
            Assert.AreEqual(10, fuelEconomy);
            Assert.AreEqual(5, litres);
            Assert.AreEqual(50, cost);

        }

        [TestMethod]
        public void TestCalculateRentalPrice()
        {
            // arrange
            Vehicle testVehicles = new Vehicle("Test Subject", "Mod-1", 2018, "TEST001", 3500, 3.5, 1000);
            testVehicles.AddJourney(30);
            testVehicles.AddFuel(1.5, 15);
            CalculateRentalPrice rentalPrice = new CalculateRentalPrice(testVehicles.Journey.Kilometers, testVehicles.FuelPurchase.Cost);
            rentalPrice.PriceByKm = 5;

            // act
            double result = rentalPrice.Calculate();

            // assert
            Assert.AreEqual(165, result);
        }

        [TestMethod]
        public void TestService()
        {
            // arrange
            Vehicle testVehicles = new Vehicle("Test Subject", "Mod-1", 2018, "TEST001", 500, 3.5, 1000);

            // act
            testVehicles.AddJourney(5);
            testVehicles.Service.RecordService(testVehicles.OdometerReading);
            testVehicles.AddJourney(3);
            testVehicles.Service.RecordService(testVehicles.OdometerReading);
            testVehicles.AddJourney(10);
            testVehicles.Service.RecordService(testVehicles.OdometerReading);
            testVehicles.AddJourney(10);
            testVehicles.Service.RecordService(testVehicles.OdometerReading);
            testVehicles.AddJourney(10);
            testVehicles.Service.RecordService(testVehicles.OdometerReading);

            int count = testVehicles.Service.ServiceCount;
            double lastServiceKm = testVehicles.Service.LastServiceOdometerKm;
            bool required = testVehicles.Service.ServiceRequired();
            int totalCount = testVehicles.Service.GetTotalScheduledServices();

            // assert
            Assert.AreEqual(5, count);
            Assert.AreEqual(538, lastServiceKm);
            Assert.AreEqual(false, required);
            Assert.AreEqual(5, totalCount);
        }
    }
}
