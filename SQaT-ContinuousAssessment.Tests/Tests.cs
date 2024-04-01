using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static SQaT_ContinuousAssessment.Tests.Calculator;

// Authored by S00237686.
namespace SQaT_ContinuousAssessment.Tests
{
    [TestFixture]
    internal class Tests
    {
        //three test should be a suffcient testing enviorment.
        //I have checked them for their limits.
        [TestCase("rural",25,5.00)]
        [TestCase("rural",30,5.00)]
        [TestCase("rural",18,5.00)]
        public void Premium_WhenRuralAged18To30OutputPremium_Returns5_00(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium));
        }

        [TestCase("rural",31,3.50)]
        [TestCase("rural",49,3.50)]
        [TestCase("rural",43,3.50)]
        //named as such since over 50 gets a flat 10% discount.
        //and this will be a continuous thing throughout
        public void Premium_WhenRuralAndAged31To49_Return3_50(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium));
        }

        [TestCase("urban", 30, 6.00)]
        [TestCase("urban", 18, 6.00)]
        [TestCase("urban", 35, 6.00)]
        public void Premium_WhenUrbanAndAged18To35_Return6_00(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium));
        }
        [TestCase("urban", 36, 5.00)]
        [TestCase("urban", 40, 5.00)]
        [TestCase("urban", 49, 5.00)]
        public void Premium_WhenUrbanAndAged36To49_Return5_00(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium));
        }

        [TestCase("rural", 15, 0.00)]
        [TestCase("urban", 13, 0.00)]
        [TestCase("urban", 17, 0.00)]
        public void Premium_WhenAgedUnder18_Return0_00(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium));
        }

        [TestCase("rural", 55, 3.15)]
        [TestCase("rural", 75, 3.15)]
        [TestCase("rural", 64, 3.15)] //this one's for you Sam and your SM64 Addiction
        public void Premium_WhenRuralAndAged50AndOver_Return3_15(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium).Within(0.01));
        }
        [TestCase("urban", 55, 4.50)]
        [TestCase("urban", 75, 4.50)]
        [TestCase("urban", 64, 4.50)] //this one's for you Sam and your SM64 Addiction ( •̀ᴗ•́ )و 
        public void Premium_WhenUrbanAndAged50AndOver_Return4_50(string location, int age, double expectedPremium)
        {
            //arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());
            //act
            var premiumOutput = insuranceService.CalcPremium(age, location);

            //assert
            Assert.That(premiumOutput, Is.EqualTo(expectedPremium).Within(0.01));
        }

        //If a negative age is input; output = "your age cannot be negative silly."
        //location doesn't matter, since it fails at the age check
        [TestCase]
        public void PremiumCalculation_NegativeAge_ThrowsArgumentException()
        {
            // Arrange
            var insuranceService = new InsuranceService(new AgeBasedDiscountService());

            // Act & Assert
            Assert.Throws<ArgumentException>(() => insuranceService.CalcPremium(-5, "rural"));
        }
    }    
}
