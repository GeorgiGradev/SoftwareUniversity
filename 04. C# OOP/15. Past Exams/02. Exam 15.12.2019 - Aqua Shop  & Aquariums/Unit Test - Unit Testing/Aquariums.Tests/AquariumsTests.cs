using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Aquariums.Tests
{
    [TestFixture]
    public class AquariumsTests
    {
        [Test]
        public void TestConstructor()
        {
            string expectedName = "Pesho";
            int expectedCapacity = 10;
            Aquarium aquarium = new Aquarium(expectedName, expectedCapacity);
            Assert.AreEqual(expectedName, aquarium.Name);
            Assert.AreEqual(expectedCapacity, aquarium.Capacity);
        }
        [Test]
        public void ExceptionWhenInvalidName()
        {
            Assert.Throws<ArgumentNullException>(() => new Aquarium("", 11));
        }
        [Test]
        public void ExceptionCapacityLessThanZerp()
        {
            Assert.Throws<ArgumentException>(() => new Aquarium("Ivan", -1));
        }
        [Test]
        public void AddToCollection()
        {
            Aquarium aquarium = new Aquarium("Ivan", 2);
            aquarium.Add(new Fish("Todor"));
            Assert.AreEqual(1, aquarium.Count);
        }
        [Test]
        public void ExceptionWhenFullAquarium()
        {
            Aquarium aquarium = new Aquarium("Ivan", 1);
            aquarium.Add(new Fish("Todor"));
            Assert.Throws<InvalidOperationException>(() => aquarium.Add(new Fish("123")));
        }
        [Test]
        public void TestRemoveFish()
        {
            Aquarium aquarium = new Aquarium("Ivan", 1);
            aquarium.Add(new Fish("Todor"));
            aquarium.RemoveFish("Todor");
            Assert.AreEqual(0, aquarium.Count);
        }
        [Test]
        public void ExceptionRemoveNotExistingFish()
        {
            Aquarium aquarium = new Aquarium("Ivan", 1);
            aquarium.Add(new Fish("Todor"));
            Assert.Throws<InvalidOperationException>(() => aquarium.RemoveFish("Pesho"));
        }
        [Test]
        public void TestSellFish()
        {
            Aquarium aquarium = new Aquarium("Ivan", 1);
            Fish fish = new Fish("Todor");
            aquarium.Add(fish);
            aquarium.SellFish("Todor");
            Assert.AreEqual(false, fish.Available);
        }
        [Test]
        public void ExceptionWhenFishDoesNotExistToBeSold()
        {
            Aquarium aquarium = new Aquarium("Ivan", 1);
            Fish fish = new Fish("Todor");
            aquarium.Add(fish);
            Assert.Throws<InvalidOperationException>(() => aquarium.SellFish("Strahil"));
        }
        [Test]
        public void TestReport()
        {
            Aquarium aquarium = new Aquarium("Aqua", 2);
            Fish fish1 = new Fish("Todor");
            Fish fish2 = new Fish("Ivan");
            aquarium.Add(fish1);
            aquarium.Add(fish2);
            
            string expectedResult = $"Fish available at Aqua: Todor, Ivan";
            string actualResult = aquarium.Report();
            Assert.AreEqual(expectedResult, actualResult);
        
        }
    }
}
