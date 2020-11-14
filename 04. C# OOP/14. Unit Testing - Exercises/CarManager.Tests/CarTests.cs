using NUnit.Framework;
using System;

//using CarManager;


namespace Tests
{
    public class CarTests
    {
        private string make;
        private string model;
        private double fuelConsumption;
        private double fuelCapacity;
        private double fuelAmount;

        [SetUp]
        public void Setup()
        {
            make = "Opel";
            model = "Vectra";
            fuelConsumption = 1;
            fuelCapacity = 50;
        }

        [Test]
        public void Test_Conmstructor()
        {
            //Act
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);

            //Asset
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(fuelConsumption, car.FuelConsumption);
            Assert.AreEqual(fuelCapacity, car.FuelCapacity);
            Assert.AreEqual(fuelAmount, car.FuelAmount);
        }
        [Test]
        public void Throw_Exeption_When_Make_Null0rEmpty()
        {
            //Arrange
            make = string.Empty;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }
        [Test]
        public void ThrowExeption_When_Model_NullorEmpty()
        {
            //Arrange
            model = string.Empty;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }
        [Test]
        public void ThrowExeption_When_FuelConsumption_Negative()
        {
            //Arrange
            fuelConsumption = -1;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [Test]
        public void ThrowExeption_When_FuelConsumption_Zero()
        {
            //Arrange
            fuelConsumption = 0;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }


        [Test]
        public void ThrowExeption_Wnen_FuelCapacity_Negative()
        {
            //Arrange 
            fuelCapacity = -1;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }


        [Test]
        public void ThrowExeption_Wnen_FuelCapacity_Zero()
        {
            //Arrange 
            fuelCapacity = 0;

            //Assert
            Assert.Throws<ArgumentException>(() => new Car(make, model, fuelConsumption, fuelCapacity));
        }

        [TestCase(0)]
        [TestCase(-1)]
        public void ThrowException_When_FuelToRefuel_Negative(double fuelToRefuel)
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            Assert.Throws<ArgumentException>(() => car.Refuel(fuelToRefuel));
        }


        [Test]
        public void TestWhen_FuelAmountBiggerThanFuelCapacity()
        {


            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(55);
            double expectedFuelAmount = 50;
            double actualFuelAmount = car.FuelAmount;

            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }


        [Test]
        public void ThrowExeption_Wnen_NotEnoughFuel()
        {     
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(40);

            Assert.Throws<InvalidOperationException>(() => car.Drive(10000));

        }

        [Test]
        public void Test_When_Enough_Fuel()
        {
            Car car = new Car(make, model, fuelConsumption, fuelCapacity);
            car.Refuel(10);
            car.Drive(100);
            var expectedFuelAmount = 9;
            var actualFuelAmount = car.FuelAmount;
            Assert.AreEqual(expectedFuelAmount, actualFuelAmount);
        }

    }
}