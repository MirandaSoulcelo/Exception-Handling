using System.Globalization;
using System.Linq.Expressions;
using Entities.Exceptions;

namespace Entities
{
    class Account
    {
        public int Number{get;set;}
        public string Holder{get;set;}
        public double Balance{get;set;}
        public double WithdrawLimit{get;set;}

        public Account(int number, string holder, double balance, double withDrawLimit)
       {
            if(withDrawLimit <= 0 )
            {
                throw new DomainException("Your withdraw limit cannot be less than or equal to zero");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
        
        public void WithDraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainException("the amount exceeds withdraw limit");
            }
            if(Balance == 0 || amount > Balance)
            {
                throw new DomainException("you don't have enough balance ");
            }
            Balance -= amount;
        }

        public override string ToString()
        {
            return "New Balance: " + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}