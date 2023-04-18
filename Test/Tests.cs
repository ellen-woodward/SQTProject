using Moq;
using NUnit.Framework;
using SQTCode;

namespace Test
{

    [TestFixture]
    public class Program
    {
        [Test]
        public void GetPremium_Returns5_WhenAgeis25LocationRural()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(25, "rural");
            //Assert
            Assert.That(premium, Is.EqualTo(5));
        }

        [Test]
        public void GetPremium_Returns2point5_WhenAgeis40LocationRural()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(40, "rural");
            //Assert
            Assert.That(premium, Is.EqualTo(2.5));
        }

        [Test]
        public void GetPremium_Returns0_WhenAgeis17LocationRural()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(17, "rural");
            //Assert
            Assert.That(premium, Is.EqualTo(0));
        }

        [Test]
        public void GetPremium_Returns6_WhenAgeis25LocationUrban()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(25, "urban");
            //Assert
            Assert.That(premium, Is.EqualTo(6));
        }

        [Test]
        public void GetPremium_Returns5andDiscount_WhenAgeis51LocationUrban()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0.5);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(51, "urban");
            //Assert
            Assert.That(premium, Is.EqualTo(2.5));
        }

        [Test]
        public void GetPremium_Returns0_WhenAgeis17LocationUrban()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(17, "urban");
            //Assert
            Assert.That(premium, Is.EqualTo(0));
        }

        [Test]
        public void GetPremium_Returns0_WhenAgeis25LocationTown()
        {
            //Arrange
            var mockDiscountService = new Mock<DiscountService>();
            mockDiscountService.Setup(x => x.GetDiscount()).Returns(0);
            var insuranceService = new InsuranceService(mockDiscountService.Object);
            //Act
            double premium = insuranceService.CalculatePremium(25, "town");
            //Assert
            Assert.That(premium, Is.EqualTo(0));
        }
    }

}