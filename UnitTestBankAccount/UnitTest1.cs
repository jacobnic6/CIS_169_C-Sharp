using BankAccount.Models;
using System;
using Xunit;

namespace UnitTestBankAccount
{
    public class UnitTest1
    {
        [Fact]
        public void TestNegativeAmount()
        {
            // ARRANGE
            BankAccount.Models.BankAccount b = new BankAccount.Models.BankAccount();
            decimal negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Amount = negativeValue);
        }
        [Fact]
        public void TestNegativeBalance()
        {
            // ARRANGE
            BankAccount.Models.BankAccount b = new BankAccount.Models.BankAccount();
            decimal negativeValue = -1;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Balance = negativeValue);
        }
        [Fact]
        public void TestOverdraft()
        {
            // ARRANGE
            BankAccount.Models.BankAccount b = new BankAccount.Models.BankAccount();
            b.Amount = 103;
            b.Balance = 102;
            // ACT 
            // ASSERT
            Assert.Throws<ArgumentOutOfRangeException>(() => b.Withdraw());
        }
    }

}
