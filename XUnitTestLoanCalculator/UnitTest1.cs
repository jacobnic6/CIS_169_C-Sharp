using System;
using Xunit;

namespace XUnitTestLoanCalculator
{
    public class UnitTest1
    {
       
            [Fact]
        public void TestNegativeLoanAmount()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            double negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.LoanAmount = negativeValue); 
        }
        [Fact]
        public void TestNegativeInterestRate()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            double negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.InterestRate = negativeValue);
        }
        [Fact]
        public void TestNegativeYear()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            int negativeValue = -12;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.YearLoan = negativeValue);
        }

        [Fact]
        public void TestRangeLoanAmount()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            double outOfRangeValue = 10000000;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.LoanAmount = outOfRangeValue);
        }

        [Fact]
        public void TestRangeInterestRate()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            double outOfRangeValue = 60;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.InterestRate = outOfRangeValue);
        }

        [Fact]
        public void TestRangeYear()
        {
            // ARRANGE
            LoanCalculator.Models.LoanCalculatorModel b = new LoanCalculator.Models.LoanCalculatorModel();
            int outOfRangeValue = 70;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.YearLoan = outOfRangeValue);
        }

        

    }
}

