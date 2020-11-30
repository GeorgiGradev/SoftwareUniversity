namespace Robots.Tests
{
    using NUnit.Framework;
    using System;
    [TestFixture]
    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;

        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Ivan", 10);
        }

        [Test]
        public void TestConstructor()
        {
            robotManager = new RobotManager(2);
            Assert.That(robotManager.Count, Is.EqualTo(0));
        }
        [Test]
        public void TestConstructor2()
        {
            robotManager = new RobotManager(2);
            Assert.AreEqual(2, robotManager.Capacity);
        }
        [Test]
        public void ExceptionWhenCapacityLessThanZero()
        {
            Assert.Throws<ArgumentException>(() => new RobotManager(-1));
        }
        [Test]
        public void TestCount()
        {
            Assert.AreEqual(0, robotManager.Count);
        }
        [Test]
        public void TestAddMethod()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            Assert.AreEqual(1, robotManager.Count);
        }
        [Test]
        public void ExceptionWhenAlrearyExistingRobot()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(new Robot("Ivan", 3)));
        }
        [Test]
        public void ExceptionWhenNotEnoughCapacity()
        {
            robotManager = new RobotManager(1);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Add(new Robot("Pesho", 3)));
        }
        [Test]
        public void TestRemoveMethod()
        {
            robotManager = new RobotManager(1);
            robotManager.Add(robot);
            robotManager.Remove(robot.Name);
            Assert.AreEqual(0, robotManager.Count);
        }
        [Test]
        public void ExceptionWhenRemoveNotExistingRobot()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("User"));
        }
        [Test]
        public void TestWorkMethod()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Work("Ivan", "jobToDo", 5);
            Assert.AreEqual(5, robot.Battery);
        }
        [Test]
        public void ExceptionWhenNameNotExisting()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Strahil", "rabota", 3));
        }
        [Test]
        public void ExceptionWhenBatteryLessThanUsage()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Ivan", "jobToDo", 20));
        }
        [Test]
        public void TestBatteryChargeMethod()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            robotManager.Work("Ivan", "jobToDo", 5);
            robotManager.Charge("Ivan");
            Assert.AreEqual(10, robot.Battery);
        }
        [Test]
        public void ExceptionNotExistingRobotToRecharge()
        {
            robotManager = new RobotManager(2);
            robotManager.Add(robot);
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("1234"));
        }
    }
}
