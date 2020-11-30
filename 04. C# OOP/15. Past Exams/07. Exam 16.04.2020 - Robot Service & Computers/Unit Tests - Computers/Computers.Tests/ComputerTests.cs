namespace Computers.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ComputerTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void TestConstructor()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            Assert.AreEqual("Ivan", computer.Name);
        }
        [Test]
        public void TestCollection()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            Assert.IsNotNull(computer);
        }
        [Test]
        public void ExceptionIfNameIsEmptyOrWhiteSpace()
        {
            Assert.Throws<ArgumentNullException>(() => new Computer(" "));
        }
        [Test]
        public void TestAddMethod()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            computer.AddPart(new Part("part", 10m));
            Assert.AreEqual(1, computer.Parts.Count);
        }
        [Test]
        public void ExceptionIfPartIsNull()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            Assert.Throws<InvalidOperationException>(() => computer.AddPart(null));
        }
        [Test]
        public void TestSumMethod()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            computer.AddPart(new Part("part", 10m));
            computer.AddPart(new Part("part1", 20m));

            Assert.AreEqual(30, computer.TotalPrice);
        }
        [Test]
        public void TestRemoveMethod()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            Part part = new Part("part", 10m);
            computer.AddPart(part);
            computer.RemovePart(part);
            Assert.AreEqual(0, computer.Parts.Count);
        }
        [Test]
        public void TestGetPartMethod()
        {
            string name = "Ivan";
            Computer computer = new Computer(name);
            Part part = new Part("part", 10m);
            computer.AddPart(part);
            Assert.AreEqual(part, computer.GetPart(part.Name));
        }
    }
}