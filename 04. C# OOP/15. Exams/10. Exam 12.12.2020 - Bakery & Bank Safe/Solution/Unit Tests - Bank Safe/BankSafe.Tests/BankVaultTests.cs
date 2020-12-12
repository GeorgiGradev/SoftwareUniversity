using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        private Dictionary<string, Item> vaultCells;
        private BankVault bankVault;
        private Item item; 


        [SetUp]
        public void Setup()
        {
            bankVault = new BankVault();
            item = new Item("Ivan", "1234");
            this.vaultCells = new Dictionary<string, Item>
            {
                {"A1", null},
                {"A2", null},
                {"A3", null},
                {"A4", null},
                {"B1", null},
                {"B2", null},
                {"B3", null},
                {"B4", null},
                {"C1", null},
                {"C2", null},
                {"C3", null},
                {"C4", null},
            };
        }

        [Test]
        public void TestConstructor()
        {
            int actualCount = vaultCells.Count;
            int expectedCount = 12;
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void ExceptionWhenItemIsNull()
        {
            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A6", null));
        }

        [Test]
        public void ExceptionWhenAlreadyExistingItem()
        {
            bankVault.AddItem("A1", item);
            Assert.Throws<ArgumentException>(() => bankVault.AddItem("A1", null));
        }

        [Test]
        public void TestAddItemMethod()
        {
            bankVault.AddItem("A1", item);
            Assert.Throws<InvalidOperationException>(() => bankVault.AddItem("A2", item));
        }

        [Test]
        public void TestReturnMessage()
        {
            Assert.That(bankVault.AddItem("A1", item), Is.EqualTo($"Item:{item.ItemId} saved successfully!"));
        }

        [Test]
        public void ExceptionWhenRemoveOfNotExistingCell()
        {
            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A7", null));
        }

        [Test]
        public void ExceptionWhenRemoveOfNotExistingItem()
        {
            Assert.Throws<ArgumentException>(() => bankVault.RemoveItem("A1", item));
        }

        [Test]
        public void TestRemoveItemMethod()
        {
            bankVault.AddItem("A1", item);
            var result = bankVault.RemoveItem("A1", item);
            var expected = $"Remove item:{item.ItemId} successfully!";
            Assert.AreEqual(expected, result);
        }

    }
}