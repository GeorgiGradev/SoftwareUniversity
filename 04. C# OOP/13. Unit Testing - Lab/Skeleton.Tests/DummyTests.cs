using NUnit.Framework;

[TestFixture]
public class DummyTests
{
    private Dummy aliveDummy;
    private Dummy deadDummy;
   [SetUp]
   public void SetUpPrep()
    {
        //Arrange
        this.aliveDummy = new Dummy(10, 10);
        this.deadDummy = new Dummy(-1, 10);
    }

    [Test]
    public void DummyLoosesHealthIfAttacked()
    {
        //Act
        aliveDummy.TakeAttack(1);
        //Assert
        Assert.That(() => aliveDummy.Health, Is.EqualTo(9));
    }

    [Test]
    public void DeadDummyThrowsExceptionIfAttacked()
    {
        //Act
        aliveDummy.TakeAttack(11);
        //Assert
        Assert.That(() => aliveDummy.TakeAttack(11), Throws.InvalidOperationException.With.Message.EqualTo("Dummy is dead."));
    }

    [Test]
    public void DeadDummyCanGiveXP()
    {
        //Assert
        Assert.That(() => deadDummy.GiveExperience(), Is.EqualTo(10));
    }

    [Test]
    public void AliveDummyCanNotGiveExperience()
    {
        //Assert
        Assert.That(() => aliveDummy.GiveExperience(), Throws.InvalidOperationException.With.Message.EqualTo("Target is not dead."));
    }
}
