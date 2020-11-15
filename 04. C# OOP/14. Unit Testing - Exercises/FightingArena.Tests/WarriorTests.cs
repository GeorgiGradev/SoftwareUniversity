using System;
using NUnit.Framework;
using FightingArena;

namespace Tests
{
    public class WarriorTests
    {
        private const int MIN_ATTACK_HP = 30;
        private string name;
        private int damage;
        private int hp;

        [SetUp]
        public void Setup()
        {
            name = "Ivan";
            damage = 50;
            hp = 100;
           
        }

        [Test]
        public void TestConstrucor()
        {
            Warrior warrior = new Warrior(name, damage, hp);
            Assert.AreEqual(name, warrior.Name);
            Assert.AreEqual(damage, warrior.Damage);
            Assert.AreEqual(hp, warrior.HP);
        }

        [Test] 
        public void ThrowExeption_Name_NullOrWhiteSpace()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(string.Empty, damage, hp));
            Assert.Throws<ArgumentException>(() => new Warrior(" ", damage, hp));
            Assert.Throws<ArgumentException>(() => new Warrior(null, damage, hp));
        }

        [Test]
        public void ThrowExeption_Damage_ZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() => { new Warrior(name, 0, hp); });
            Assert.Throws<ArgumentException>(() => { new Warrior(name, -1, hp); });
        } 

        [Test]
        public void ThrowExeption_HP_Negative()
        {
            Assert.Throws<ArgumentException>(() => new Warrior(name, damage, -1));
        }

        [Test]
        public void ThrowExeption_IfHPlessThenMinAttackHP()
        {
            Warrior warrior1 = new Warrior("Ivan", 15, 29);
            Warrior warrior2 = new Warrior("Pesho", 15, 31);
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void ThrowExeption_IfHPEqualThanMinAttackHP()
        {
            Warrior warrior1 = new Warrior("Ivan", 15, 30);
            Warrior warrior2 = new Warrior("Pesho", 15, 30);
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void ThrowExeption_IfWarriorHPLessThanMinAttackHP()
        {
            Warrior warrior1 = new Warrior("Ivan", 15, 31);
            Warrior warrior2 = new Warrior("Pesho", 15, 29);
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }
        [Test]
        public void ThrowExeption_IfWarriorHPEqualToMinAttackHP()
        {
            Warrior warrior1 = new Warrior("Ivan", 15, 30);
            Warrior warrior2 = new Warrior("Pesho", 15, 29);
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }

        [Test]
        public void ThrowExeption_IfWarrior1HP_LessThanWarrior2Damage()
        {
            Warrior warrior1 = new Warrior("Ivan", 30, 31);
            Warrior warrior2 = new Warrior("Pesho", 32, 31);
            Assert.Throws<InvalidOperationException>(() => warrior1.Attack(warrior2));
        }


        [Test]
        public void AttackingShouldDecreaseHPWhenSucessfull()
        {
            //Arrange
            Warrior attackker = new Warrior("Ivan", 10, 40);
            Warrior deffender = new Warrior("Pesho", 5, 50);
            int expectedAttackerHP = 35;
            int expectedDeffenderHP = 40;
            //Act
            attackker.Attack(deffender);
            //Assert
            Assert.AreEqual(expectedAttackerHP, attackker.HP);
            Assert.AreEqual(expectedDeffenderHP, deffender.HP);
        }
 
        [Test]
        public void Test_IfWarrior1HPisLessThan_Warrior2Damage()
        {
            //Arrange
            Warrior attacker = new Warrior("Ivan", 62, 62);
            Warrior deffemder = new Warrior("Pesho", 31, 31);
            int expectedAttackerHP = 31;
            int expectedDeffenderHP = 0; //31 - 62 
             //Act
            attacker.Attack(deffemder);
            //Assert
            Assert.AreEqual(expectedAttackerHP, attacker.HP);
            Assert.AreEqual(expectedDeffenderHP, deffemder.HP);
        }
            

    }
}