using NUnit.Framework;
using FightingArena;
using System;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior warrior1;
        private Warrior warrior2;

        [SetUp]
        public void Setup()
        {
            this.arena = new Arena();
            this.warrior1 = new Warrior("Pesho", 10, 80);
            this.warrior2 = new Warrior("Ivan", 5, 60);
        }

        [Test]
        public void TestConstructor()
        {
            Assert.IsNotNull(this.arena.Warriors);
        }
         
       [Test]
       public void ENROLL_ShouldAddWarriorToArena()
        {
            this.arena.Enroll(this.warrior1);
            Assert.That(this.arena.Warriors, Has.Member(this.warrior1));
        }

        [Test]
        public void TestCount()
        {
            this.arena.Enroll(this.warrior1);
            Assert.That(arena.Count, Is.EqualTo(1));
        }

        [Test]
        public void ENROL_SameWarrior_ThrowExeptiom()
        {
            this.arena.Enroll(this.warrior1);

            Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(this.warrior1));
        }

        [Test]
        public void ENROL_WarriorWithSameName_DifferentObject()
        {
            Warrior warriorCopy = new Warrior(warrior1.Name, warrior1.Damage, warrior1.HP);
            arena.Enroll(warrior1);
            Assert.Throws<InvalidOperationException>(() => this.arena.Enroll(warriorCopy));
        }
        
        [Test]
        public void ThrowExeptionIfAttackerNameIsNull()
        {
            arena.Enroll(warrior1);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior1.Name, warrior2.Name));
        }
        [Test]
        public void ThrowExeptionIfDeffenderNameIsNull()
        {
            arena.Enroll(warrior2);
            Assert.Throws<InvalidOperationException>(() => arena.Fight(warrior1.Name, warrior2.Name));
        }
        [Test]
        public void TestWorkingFIGHT()
        {
            arena.Enroll(warrior1);
            arena.Enroll(warrior2);
            

            int expectedWarrior1HP = warrior1.HP - warrior2.Damage;
            int expectedWarrior2HP = warrior2.HP - warrior1.Damage;
            arena.Fight(warrior1.Name, warrior2.Name);
            Assert.AreEqual(expectedWarrior1HP, warrior1.HP);
            Assert.AreEqual(expectedWarrior2HP, warrior2.HP);

        }


    }
}
 