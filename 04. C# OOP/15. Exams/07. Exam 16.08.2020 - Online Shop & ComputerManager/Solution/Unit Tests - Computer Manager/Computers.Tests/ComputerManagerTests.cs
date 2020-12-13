using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Computers.Tests
{
    public class Tests
    {
        private string manufacturer;
        private Computer computer;
        private ComputerManager computerManager;
        private List<Computer> computers;

        [SetUp]
        public void Setup()
        {
            computer = new Computer("HP", "Spectre", 2000m);
            computerManager = new ComputerManager();
            this.computers = new List<Computer>();
        }

        [Test] // 01
        public void TestContructor()
        {
            Assert.IsNotNull(computerManager); 
        }

        [Test] // 03
        public void TestCountMethod()
        {
            Assert.AreEqual(0, computerManager.Count);
        }

        [Test] //04
        public void TestAddANDCountMethods()
        {
            computerManager.AddComputer(computer);
            Assert.AreEqual(1, computerManager.Count);
        }

        [Test] // 08 & 09
        public void RemoveShouldThrowExceptionWithInvalidComputer()
        {
            computerManager.AddComputer(computer);
            Assert.Throws<ArgumentException>(() =>
            {
                this.computerManager.RemoveComputer("1234", "45345");
            }, "There is no computer with this manufacturer and model.");
        }

        [Test] // 06
        public void ExceptionIfComputerAlreadyExists()
        {
            computerManager.AddComputer(computer);
            Assert.Throws<ArgumentException>(() => computerManager.AddComputer(new Computer("HP", "Spectre", 1000)));
        }

        [Test] // 05
        public void ExceptionWhenAddComputerNULL()
        {
            Assert.Throws<ArgumentNullException>(() => computerManager.AddComputer(null));
        }

        [Test] // 10
        public void ExceptionWhenGetComputerMethodManufacturerNULL()
        {
            computerManager.AddComputer(computer);
            Assert.Throws<ArgumentNullException>(() => computerManager.GetComputer(null, "Spectre"));
        }

        [Test] // 02
        public void TestGetComputerByManufacturerMethod()
        {
            manufacturer = "HP";
            Computer computer1 = new Computer(manufacturer, "123", 200m);
            Computer computer2 = new Computer(manufacturer, "23445", 300m);
            Computer computer3 = new Computer("test", "53453", 40m);
            computerManager.AddComputer(computer1);
            computerManager.AddComputer(computer2);
            computerManager.AddComputer(computer3);
            var result2 = computerManager.GetComputersByManufacturer("HP");
            Assert.AreEqual(result2, new List<Computer> { computer1, computer2 });
        }

        [Test] //07
        public void TestAddComputerComputerMethod() 
        {
            computerManager.AddComputer(computer);
            Assert.That(computerManager.Computers, Has.Member(computer));
        }
    }
}