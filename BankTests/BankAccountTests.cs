 using UnitTestingDemo;

namespace BankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void Debit_WithValidAmount_UpdateBalance()
        {
            double beginningBalance = 15.99;
            double debitAmount = 5.6;
            double expectedResult = 10.39;
            BankAccount bankAccount = new BankAccount("Arvind", beginningBalance);

            bankAccount.Debit(debitAmount);

            double actual=bankAccount.Balance;
            Assert.AreEqual(expectedResult, actual,0.001,"Account not debited correctly ");

        }

        [TestMethod]
        public void Debit_WhenAmountIsLessThanZero()
        {
            double beginningBalance = 15.99;
            double debitAmount = -100.00;
            BankAccount bankAccount = new BankAccount("Ram", beginningBalance);

            Assert.ThrowsException<System.ArgumentOutOfRangeException>(()=> bankAccount.Debit(debitAmount));
        }

        [TestMethod]
        public void Debit_WhenAmountIsMoreThanBalance()
        {
            double beginningBalance = 15.99;
            double debitAmount = 20;
            BankAccount bankAccount = new BankAccount("Ajay", beginningBalance);

            try
            {
                bankAccount.Debit(debitAmount);
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                StringAssert.Contains(e.Message, BankAccount.DebitAmountExceedsBalanceMessage);
                return;
            }

            Assert.Fail("The expected error was not thrown");
        }
    }
}