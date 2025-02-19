using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Runtime.InteropServices.ComTypes;

namespace gabrielPortella
{
    [TestClass]
    public class CalculatorTests
    {
        [TestMethod]
        public void AnnualRentTest()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            // Act
            double annualIncome = income.GetAnnualIncome(100000);

            // Assert   
            Assert.AreEqual(1200000, annualIncome);
        }

        [TestMethod]
        public void WeeklyIncomeTest()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            // Act
            double weeklyIncome = income.GetWeeklyIncome(2600000);

            // Assert   
            Assert.AreEqual(50000, weeklyIncome);
        }

        [TestMethod]
        public void AnnualRentNegativeTest()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            try
            {
                double annualIncome = income.GetAnnualIncome(-100000);

                Assert.Fail("This code should not be run");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Income must be greater than zero", ex.Message);
            }
           
        }

        [TestMethod]
        public void WeeklyIncomeNegativeTest()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            try
            {
                double weeklyIncome = income.GetWeeklyIncome(0);

                Assert.Fail("This code should not be run");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("Income must be greater than zero", ex.Message);

            }

        }

        [TestMethod]
        public void TaxPayment()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            // Act
            TaxEntries taxdata  = income.GetTaxPayment(1500000,50000);

            Assert.AreEqual(600000.00, taxdata.TaxAmount);
            Assert.AreEqual(62500.00, taxdata.DonationDeduct);
            Assert.AreEqual(537500.00, taxdata.NetTaxAmount);
            Assert.AreEqual(962500.00, taxdata.NetIncome);

        }

        [TestMethod]
        public void TaxPaymentNegative()
        {
            // Arrange
            IncomeCalculator income = new IncomeCalculator();

            try
            {
                TaxEntries taxdata = income.GetTaxPayment(-1500000, -50000);

                Assert.Fail("This code should not be run");
            }
            catch (InvalidOperationException ex)
            {
                Assert.AreEqual("The annual earning and donation amount must be greater than zero", ex.Message);

            }
        }

    }
}
