
namespace Tests
{
    using ExtendedDatabase;
    using NUnit.Framework;
    using System;

    [TestFixture]
    public class ExtendedDatabaseTests
    {
        private ExtendedDatabase database;
        private Person person1;
        private Person person2;

        [SetUp]
        public void Setup()
        {
            person1 = new Person(123, "Pesho");
            person2 = new Person(321, "Gosho");
            database = new ExtendedDatabase(person1, person2);
        }

        [Test]
        public void Constructor_ShouldInitializeCorrectlyPersonClass()
        {
            Assert.That(this.person1.UserName, Is.Not.EqualTo(null));
            Assert.That(this.person1.UserName, Is.EqualTo("Pesho"));
            Assert.That(this.person1.Id, Is.Not.EqualTo(0));
            Assert.That(this.person1.Id, Is.EqualTo(123));
        }

        [Test]
        public void TestCount()
        {
            var database = new ExtendedDatabase(person2, person1);
            var actualCount = database.Count;
            var expectedCount = 2;

            Assert.AreEqual(actualCount, expectedCount);

        }

        [Test]
        public void Add_ExeptionMessageWhenCapacityIsReached()
        {
            database = new ExtendedDatabase();
            for (int i = 0; i < 16; i++)
            {
                database.Add(new Person(i, i.ToString()));
            }

            Assert.That(() => database.Add(person1), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void Add_ExeptionMessageWhenSameUserName()
        {
            var person2 = new Person(124, "Pesho");

            Assert.That(() => database.Add(person2), Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this username!"));
        }

        [Test]
        public void Add_ExeptionMessageWhenSameID()
        {
            var person3 = new Person(123, "Ivan");
            Assert.That(() => database.Add(person3), Throws.InvalidOperationException.With.Message.EqualTo("There is already user with this Id!"));
        }

        [Test]
        public void Remove_ExeptionMessageIfCollectionEmpty()
        {
            database = new ExtendedDatabase(person1);
            database.Remove();
            Assert.Throws<InvalidOperationException>(() => database.Remove());
        }
        [Test]
        public void FindByUsername_ExeptionMessageIfNull()
        {
            Assert.That(() => database.FindByUsername(null), Throws.ArgumentNullException);
        }

        [Test]
        public void FindByUsername_ExeptionWhenWrongName()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindByUsername("Ivan"));
        }
        [Test]
        public void FindByUserNameSuccesfully()
        {
            var actualPerson = database.FindByUsername("Pesho");
            var actualName = actualPerson.UserName;
            var expectedName = "Pesho";
            Assert.AreEqual(actualName, expectedName);
        }



        //    Person person = this.persons.First(p => p.Id == id);
        //    return person;
        //}

        [Test]
        public void FindByID_ExeptionMessageIfNegative()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => database.FindById(-1));
        }

        [Test]
        public void FindByID_ExeptionMessageIfWrongID()
        {
            Assert.Throws<InvalidOperationException>(() => database.FindById(111));
        }
        [Test]
        public void FindByID_Succesfully()
        {
            var actualPerson = database.FindById(123);
            var actualID = actualPerson.Id;
            var expectedID = 123;
            Assert.AreEqual(actualID, expectedID);
        }
    }
}