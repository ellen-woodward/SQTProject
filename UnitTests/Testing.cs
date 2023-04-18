using System;

    using Moq;
    using NUnit.Framework;
    using SQTProject;


    namespace NUnitTests
    {
        [TestFixture]
        public class Program
        {
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

            [Test]
            public void CalculatePremium_ReturnsDiscountedPremium_WhenAgeIs50OrAbove_Rural()
            {
                // Arrange
                var dsMock = new Mock<DiscountService>();


                dsMock.Setup(d => d.GetDiscount()).Returns(0.9);

                var insuranceService = new InsuranceService(dsMock.Object);

                // Act
                var premium = insuranceService.CalculatePremium(50, "rural");

                // Assert
                Assert.AreEqual(2.2, premium);
            }
        }
    }




