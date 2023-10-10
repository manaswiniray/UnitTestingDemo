using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestingDemo
{
    public class BankAccount
    {
        private readonly string _customerName;
        private double _balance;

        public const string DebitAmountExceedsBalanceMessage = "Debit Amount Exceeeds Balance";
        public const string DebitAmountLessThanZeroMessage = "Debit Amount is less than zero";

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            _customerName = customerName;
            _balance = balance;
        }

        public string CustomerName { get { return _customerName; } }
        public double Balance { get { return _balance; } }

        public void Debit(double amount)
        {
            if (amount > _balance)
            {
                throw new System.ArgumentOutOfRangeException("Amount",amount,DebitAmountExceedsBalanceMessage);
            }
            if(amount < 0)
            {
                throw new System.ArgumentOutOfRangeException("Amount",amount,DebitAmountLessThanZeroMessage);
            }
            _balance -= amount;     
        }

        public void Credit(double amount)
        {
            if (amount < 0){
                throw new ArgumentOutOfRangeException("Amount");
            }
            _balance += amount;
        }
    }
}
