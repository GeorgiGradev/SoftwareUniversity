using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace ParkingSystem.Tests
{
    public class SoftParkTest
    {
        private Dictionary<string, Car> parking;
        private SoftPark softPark;
        private Car car1;

        [SetUp]
        public void SetUp()
        {
            softPark = new SoftPark();
            car1 = new Car("Opel", "1234");
            this.parking = new Dictionary<string, Car>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };     
        }


        [Test]
        public void TestConstructor()
        {
            int actualCount = parking.Count;
            int expectedCount = 12;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ExceptionWhenTryToParkOnNotExistingSpot()
        {
            Assert.Throws<ArgumentException>(() => softPark.ParkCar("A6", null));
        }

        [Test]
        public void ExceptionWhenParkingSpotTaken()
        {
            softPark.ParkCar("A1", car1);
            Assert.Throws<ArgumentException>(() => softPark.ParkCar("A1", null));
        }
        [Test]
        public void ExceptionWhenTryToParkAlreadyParkedCar()
        {
            softPark.ParkCar("A1", car1);
            Assert.Throws<InvalidOperationException>(() => softPark.ParkCar("A2", car1));
        }
        [Test]
        public void ParkSuccessfully()
        {
            Assert.That(softPark.ParkCar("A1", car1), Is.EqualTo("Car:1234 parked successfully!"));
            
        }
        [Test]
        public void ExceptionIfParkSpotDoesNotExistWhenRemoveCar()
        {
            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("A7", null));
        }
        [Test]
        public void ExceptionWhenTryToRemoveCarWhichIsNotOnThatSpot()
        {
            Assert.Throws<ArgumentException>(() => softPark.RemoveCar("A1", car1));
        }
        [Test]
        public void SuccessfullyRemoveCar()
        {
            softPark.ParkCar("A1", car1);
            var result = softPark.RemoveCar("A1", car1);
            var expected = "Remove car:1234 successfully!";
            Assert.AreEqual(expected, result);
        }
    }
}