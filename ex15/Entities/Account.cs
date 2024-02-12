using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ex15.Entities.Exceptions;

namespace ex15.Entities
{
    public class Account
    {
        public int Number { get; private set; }
        public string Houlder { get; private set; }
        public double Balance { get; private set; }
        public double WithdrawLimit { get; private set; }

        public Account(int number, string houlder, double balance, double withdrawLimit)
        {
            Number = number;
            Houlder = houlder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double deposit)
        {
            Balance += amount;
        }
        public void Withdraw(double draw)
        {
            if (draw > WithdrawLimit)
            {
                throw new DomainException("Reservation dates for update must be future dates");
            }
            else if (amount > Balance)
            {
                throw new DomainException("Not enough balance");
            }
            
            Balance -= amount;
        }
    }
}