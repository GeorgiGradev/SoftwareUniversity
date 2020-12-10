using NUnit.Framework;
using System;

namespace TheRace.Tests
{
    public class RaceEntryTests
    {
        private UnitDriver unitDriver;
        private UnitCar unitCar;
        private RaceEntry raceEntry;

        [SetUp]
        public void Setup()
        {
            unitCar = new UnitCar("Opel", 100, 2000);
            unitDriver = new UnitDriver("Ivan", unitCar);
        }

        [Test] // 01
        public void TestConstructor()
        {
            Assert.IsNull(raceEntry);
            raceEntry = new RaceEntry();
            Assert.IsNotNull(raceEntry);
        }

        [Test] // 02
        public void TestAddMethod()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddDriver(unitDriver);

            Assert.AreEqual(1, raceEntry.Counter);
        }

        [Test] // 03
        public void ExceptionWhenDriverIsNull()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                RaceEntry raceEntry = new RaceEntry();
                raceEntry.AddDriver(null);
            });
        }

        [Test] // 04
        public void ExceptionWhenDriverAlreadyAdded()
        {

            Assert.Throws<InvalidOperationException>(() =>
            {
                RaceEntry raceEntry = new RaceEntry();
                raceEntry.AddDriver(unitDriver);
                raceEntry.AddDriver(unitDriver);
            });
        }
        [Test] //05
        public void TestAverageMethod()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddDriver(new UnitDriver("Stoian", new UnitCar("model", 200, 4000)));
            raceEntry.AddDriver(new UnitDriver("Pesho", new UnitCar("model1", 100, 2000)));
            Assert.That(raceEntry.CalculateAverageHorsePower, Is.EqualTo(150));
        }
        [Test] // 06
        public void ExceptionWhenLessThan2Drivers()
        {
            RaceEntry raceEntry = new RaceEntry();
            raceEntry.AddDriver(new UnitDriver("Stoian", new UnitCar("model", 200, 4000)));
            Assert.Throws<InvalidOperationException>(() => raceEntry.CalculateAverageHorsePower());
        }

    }
}