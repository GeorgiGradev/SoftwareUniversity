namespace Presents.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    public class PresentsTests
    {
        private Bag bag;
        private ICollection<Present> presents;

        [SetUp]
        public void SetUp()
        {
            this.bag = new Bag();
            presents = new List<Present>();
        }

        [Test]
        public void TestPresentConstructor()
        {
            string expectedName = "stick";
            int expextedMagic = 100;

            Present present = new Present(expectedName, expextedMagic);
            Assert.AreEqual(expectedName, present.Name);
            Assert.AreEqual(expextedMagic, present.Magic);
        }
        [Test]
        public void TestBagConstructor()
        {
            Assert.IsNotNull(bag.GetPresents());
        }
        [Test]
        public void ExceptionWhenCreateWithNullPresent()
        {
            Assert.Throws<ArgumentNullException>(() => bag.Create(null));
        }
        [Test]
        public void ExceptionWhenPresentAlreadyExists()
        {
            Present present = new Present("Name1", 10);
            bag.Create(present);
            Assert.Throws<InvalidOperationException>(() => bag.Create(present));
        }
        [Test]
        public void CreateShoudAddPresents()
        {
            string name = "Stick";
            int magic = 100;

            Present present1 = new Present(name, magic);
            Present present2 = new Present(name, magic);

            bag.Create(present1);
            bag.Create(present2);

            IReadOnlyCollection<Present> expected = new List<Present>()
            {
                present1, present2
            };
            IReadOnlyCollection<Present> actual = bag.GetPresents();
            CollectionAssert.AreEqual(expected, actual);
        }
        [Test]
        public void TestRemoveMetho()
        {
            Present present = new Present("name", 15);
            bag.Create(present);
            Assert.IsTrue(bag.Remove(present));
        }
        [Test]
        public void TestGetPresentWithLeastMagic()
        {
            var present1 = new Present("Name1", 20);
            var present2 = new Present("Name2", 10);
            bag.Create(present1);
            bag.Create(present2);
            var result = present2;
            var actual = bag.GetPresentWithLeastMagic();
            Assert.AreEqual(result, actual);
        }
        [Test]
        public void TestGetPresentByName()
        {
            var present1 = new Present("Name1", 20);
            var present2 = new Present("Name2", 10);
            bag.Create(present1);
            bag.Create(present2);
            var result = present2;
            var actual = bag.GetPresent(present2.Name);
            Assert.AreEqual(result, actual);
        }
    } 
}
