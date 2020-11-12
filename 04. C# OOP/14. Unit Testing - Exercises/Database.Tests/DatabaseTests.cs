using NUnit.Framework;
using System;

namespace Tests
{
   [TestFixture]
    public class DatabaseTests
    {
 
        private Database.Database database;
        private readonly int[] initialData = new int[] { 1, 2, 3 };

        [SetUp]
        public void Setup()
        {
            database = new Database.Database(initialData);
        }

        [Test]
        public void TestIfConstructorWorksCorrectly()
        {
            int[] data = new int[] { 1, 2, 3 };
            int expectedCount = data.Length;
            int actualCount = this.database.Count;
            Assert.AreEqual(expectedCount, actualCount);
        }
        //[Test]
        //public void ConstructorShouldThrowExceptionWhenInitializingWithBiggerCollection()
        //{
        //    int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
        //    Assert.That(() => this.database = new Database.Database(data), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        //}

        [Test]
        public void ConstructorShouldThrowExceptionWhenInitializingWithBiggerCollection()
        {
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Assert.Throws<InvalidOperationException>(() => this.database = new Database.Database(data));
        }

        [Test]
        public void AddShouldIncreaseCountWhenAddedSuccessfuly()
        {
            this.database.Add(4);
            int expextedCount = 4;
            int actualCount = this.database.Count;

            Assert.AreEqual(expextedCount, actualCount);
        }

        [Test]
        public void AddToFullCollectionShouldGiveExeptionWhenDatabaseIsFull()
        {
            //Arange
            int[] data = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            database = new Database.Database(data);

            //Assert
            Assert.That(() => database.Add(1), Throws.InvalidOperationException.With.Message.EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void RemoveElementFromEmptyCollection()
        {
            //Arrange
            this.database = new Database.Database();

            //Assert
            Assert.That(() => database.Remove(), Throws.InvalidOperationException.With.Message.EqualTo("The collection is empty!"));
        }

        [Test]
        public void RemoveElementfromNotEmptyCollection()
        {
            //Arramge
            var actualCount = database.Count;
            var expextedCount = actualCount - 1;

            //Act
            database.Remove();

            //Assert
            Assert.AreEqual(database.Count, expextedCount);
        }

        [TestCase(new int[] { 1, 2, 3})]
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16})]
        public void FetchShouldReturnCopyFromData(int[] expextedData)
        {
            this.database = new Database.Database(expextedData);
            int[] actualData = database.Fetch();
            CollectionAssert.AreEqual(expextedData, actualData);
        }  
    }
}