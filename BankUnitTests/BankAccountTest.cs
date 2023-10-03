using IntroToUnitTests;

namespace BankUnitTests
{
    [TestClass]
    public class BankAccountTest
    {

        // naming: [Method] _ [Circumstances] _ [Expected Outcome]
        // test methods should return void
        [TestMethod]
        public void Withdraw_ValidAmount_SubtractsArgumentFromBalance()
        {
            // arrange
            decimal initialBalance = 5;
            decimal withdrawalAmount = 2.55M;
            decimal expectedBalance = initialBalance - withdrawalAmount;

            BankAccount testAccount = new BankAccount(initialBalance);

            // act
            testAccount.Withdraw(withdrawalAmount);

            // assert
            Assert.AreEqual(expectedBalance, testAccount.Balance);
        }

        [TestMethod]
        public void Withdraw_ValidAmount_ReturnsNewBalance()
        {
            // arrange
            decimal initialBalance = 5;
            decimal withdrawalAmount = 2.55M;
            decimal expectedBalance = initialBalance - withdrawalAmount;

            BankAccount testAccount = new BankAccount(initialBalance);

            // act and assert
            Assert.AreEqual(expectedBalance, testAccount.Withdraw(withdrawalAmount));
        }

        [TestMethod]
        public void Withdraw_GreaterThanBalance_ThrowsInvalidOperation()
        {
            // arrange
            decimal initialBalance = 5;
            decimal withdrawalAmount = 10;

            BankAccount testAccount = new BankAccount(initialBalance);

            // act and assert simultaneously
            Assert.ThrowsException<InvalidOperationException>(() =>
            {
                testAccount.Withdraw(withdrawalAmount);
            });
        }

        [TestMethod]
        public void Withdraw_ZeroOrLess_ThrowsArgumentOutOfRangeException()
        {
            // arrange
            decimal invalidWithdrawalAmountZero = 0;
            decimal invalidWithdrawalAmountNegative = -2;

            BankAccount testAccount = new BankAccount(0);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                testAccount.Withdraw(invalidWithdrawalAmountZero);
            });

            Assert.ThrowsException<ArgumentOutOfRangeException>(() =>
            {
                testAccount.Withdraw(invalidWithdrawalAmountNegative);
            });
        }

        // TDD: Test-Driven Development
        
    }
}