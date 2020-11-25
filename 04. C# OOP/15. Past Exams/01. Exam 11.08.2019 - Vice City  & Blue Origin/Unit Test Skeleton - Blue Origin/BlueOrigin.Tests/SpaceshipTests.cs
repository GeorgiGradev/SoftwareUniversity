namespace BlueOrigin.Tests
{
    using System;
    using System.Collections.Generic;
    using NUnit.Framework;

    public class SpaceshipTests
    {
        private const string AstronautName = "Pesho";
        private const double AstronautOxygenInPercentage = 10;
        private const string SpaceShipName = "Vostok";
        private const int SpaceShipCapacity = 5;
        private ICollection<Astronaut> astronauts;


        [SetUp]
        public void SetUp()
        {

        }
        [Test]
        public void TestAstronautConstructor()
        {
            string expectedName = "Pesho";
            double expectedOxygenPercentage = 10;
            Astronaut astronaut = new Astronaut(AstronautName, AstronautOxygenInPercentage);
            Assert.AreEqual(expectedName, astronaut.Name);
            Assert.AreEqual(expectedOxygenPercentage, astronaut.OxygenInPercentage);
        }
        [Test]
        public void TestSpaceShipConstructor()
        {
            string expectedSpaceShipName = "Vostok";
            int expectedSpaceShipCapacity = 5;
            Spaceship spaceship = new Spaceship(SpaceShipName, SpaceShipCapacity);
            Assert.AreEqual(expectedSpaceShipName, spaceship.Name);
            Assert.AreEqual(expectedSpaceShipCapacity, spaceship.Capacity);
        }
        [Test]
        public void TestCount()
        {
            Spaceship spaceShip = new Spaceship("111", 10);
            Assert.AreEqual(0, spaceShip.Count);
        }
        [Test]
        public void ExeptionWhenNameNullOrEmpty()
        {
            Assert.Throws<ArgumentNullException>(() => new Spaceship("", 10));
        }
        [Test]
        public void ExeptionWhenCapacityIsReached()
        {

            Assert.Throws<ArgumentException>(() => new Spaceship("1234", -1));

        }
        [Test]
        public void ExeptionWhenAddCapacityIsReached()
        {

            Spaceship spaceship = new Spaceship("1234",1);
            string name = "Pesho";
            double percentage = 10;
            Astronaut astronaut = new Astronaut(name, percentage);
            spaceship.Add(astronaut);
            Assert.Throws<InvalidOperationException>(() => spaceship.Add(new Astronaut("ewqed", 15)));

        }
        [Test]
        public void ExpeptionUserAlreadyExists()
        {
            Spaceship spaceship = new Spaceship("1234", 2);
            spaceship.Add(new Astronaut("321", 50));
            Assert.Throws<InvalidOperationException>(() => spaceship.Add(new Astronaut("321", 43)));
        }
        [Test]
        public void TestRemoveAstronaut()
        {
            Spaceship spaceship = new Spaceship("1234", 2);
            string name = "Pesho";
            double percentage = 10;
            Astronaut astronaut = new Astronaut(name, percentage);
            spaceship.Add(astronaut);
            Assert.True(spaceship.Remove("Pesho"));
            Assert.False(spaceship.Remove("Ivan"));
        }
    }
}
