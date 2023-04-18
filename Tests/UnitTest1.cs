using Moq;
using SQTProject;
using NUnit.Framework;

namespace Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CalculatePremium_ReturnsDiscountedPremium_WhenAgeIs50OrAbove_Urban()
    {
        // Arrange
        var dsMock = new Mock<DiscountService>();

        dsMock.Setup(d => d.GetDiscount()).Returns(0.9);

        var insuranceService = new InsuranceService(dsMock.Object);

        // Act
        var premium = insuranceService.CalculatePremium(50, "urban");

        // Assert
        Assert.AreEqual(4.5, premium);
    }
}
