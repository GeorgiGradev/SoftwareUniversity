using NUnit.Framework;

[TestFixture]
public class AxeTests
{
    private Dummy target;

    [SetUp]
    public void Initialize()
    {
        target = new Dummy(5, 5);
    }

    [Test]
    public void AxeLoosesDurabilityAfterAttack()
    {
        //Arrange
        Axe axe = new Axe(2, 2);
        //Act
        axe.Attack(target);
        //Assert
        Assert.That(axe.DurabilityPoints, Is.EqualTo(1));
    }

    [Test]
    public void AttackWithBrokenAxe()
    {
        //Arrange
        Axe axe = new Axe(2, 1);
        // Act
        axe.Attack(target);
        // Assert
        Assert.That(() => axe.Attack(target), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
    }


}