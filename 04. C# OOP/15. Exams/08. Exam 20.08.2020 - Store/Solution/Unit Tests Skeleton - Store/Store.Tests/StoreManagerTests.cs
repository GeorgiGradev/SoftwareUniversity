using NUnit.Framework;
using System;

namespace Store.Tests
{
    public class StoreManagerTests
    {
        private Product product;
        private Product product2;
        private StoreManager storeManager;

        [SetUp]
        public void Setup()
        {
            product = new Product("Name", 1, 2.0m);
            product2 = new Product("Name2", 1, 3.0m);
            storeManager = new StoreManager();
        }

        [Test]    
        public void TestStoreManagerConstructor()
        {
            StoreManager storeManager = new StoreManager();
            Assert.That(storeManager.Products.Count, Is.EqualTo(0));
        }
        [Test]      
        public void TestAddMethod()
        {
            storeManager.AddProduct(product);
            Assert.AreEqual(1, storeManager.Count);
        }
        [Test]
        public void Buy_Product_Should_Return_Correct_Product_Price()
        {
            var storeManager = new StoreManager();

            storeManager.AddProduct(new Product("Pizza", 10, 0.1m));

            var price = storeManager.BuyProduct("Pizza", 5);

            Assert.That(price, Is.EqualTo(0.5));
        }

        [Test]
        public void TestMethodGetTheMostExpensiveProduct()
        {
            storeManager.AddProduct(product);
            storeManager.AddProduct(product2);
            Assert.AreEqual(product2, storeManager.GetTheMostExpensiveProduct());
        }
    }
}