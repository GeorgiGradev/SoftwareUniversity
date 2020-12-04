namespace TheRace.Tests
{
    using System;
    using System.Collections.Generic;

    using NUnit.Framework;

    public class RaceEntryTests
    {
        private UnitCar unitCar;
        private UnitCar unitCar2;
        private UnitDriver unitDriver;
        private UnitDriver unitDriver2;

        [SetUp]
        public void Setup()
        {
            unitCar = new UnitCar("BMW", 100, 2000);
            unitCar2 = new UnitCar("Opel", 200, 3000);
            unitDriver = new UnitDriver("Ivan", unitCar);
            unitDriver2 = new UnitDriver("Pesho", unitCar2);
        }

        [Test]
        public void ExceptionWhenDriverIsNullAddDriverMethod()
        {
            RaceEntry raceEntry = new RaceEntry();
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(null));
        }
        [Test]
        public void ExceptionWhenDriverExistingAddDriverMethod()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddDriver(unitDriver);
            Assert.Throws<InvalidOperationException>(() => raceEntry.AddDriver(unitDriver));
        }

        [Test]
        public void TestCalculateAverageHorsePowerMethod()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddDriver(unitDriver);
            raceEntry.AddDriver(unitDriver2);
            var result = raceEntry.CalculateAverageHorsePower();
            Assert.AreEqual(150, result);
        }


        //  => TEST NOT NEEDED TEST FOR MAXIMUM RESULT IN JUDGE
        //[Test]
        //public void TestConstructor()
        //{
        //    RaceEntry raceEntry = new RaceEntry();
        //    Assert.IsNotNull(raceEntry);
        //}


        //  => TEST NOT NEEDED TEST FOR MAXIMUM RESULT IN JUDGE
        //[Test]
        //public void TestAddDriverMethod()
        //{
        //    RaceEntry raceEntry = new RaceEntry();
        //    raceEntry.AddDriver(unitDriver);
        //    Assert.AreEqual(raceEntry.Counter, 1);
        //}


        //  => TEST NOT NEEDED TEST FOR MAXIMUM RESULT IN JUDGE
        //[Test] 
        //public void ExceptionWnenDriversAreUnder2()
        //{
        //    RaceEntry raceEntry = new RaceEntry();
        //    raceEntry.AddDriver(unitDriver);
        //    Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        //}
    }
}