using System;

namespace BankingLogic
{
    public delegate void AccountHandler();

    public class Account
    {
        public event AccountHandler underBalance, overBalance;

        public double Balance {get; set;}
        
        public Account(double amount)
        {
            this.Balance = amount;
        }

        public void Withdraw(double amount)
        {
            this.Balance -= amount;
            if (Balance <= 1000)
            {
                underBalance(); //Fire Envent
            }
        }

        public void Deposite(double amount)
        {
            this.Balance += amount;
            if(Balance >= 250000)
            {
                overBalance(); //Fire Envent
            }
        }
    }

}