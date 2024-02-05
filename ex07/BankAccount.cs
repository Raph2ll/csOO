using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ex07
{
    public class BankAccount
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }


        public BankAccount(int number, string holder)
        {
            Number = number;
            Holder = holder;
            Balance = 0;

        }
        public BankAccount(int number, string holder, double balance) : this(number, holder)
        {
            Deposit(balance)
        }

        public void Deposit(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Depoist cannot be negative.");
            }

            Balance += value;
        }
        public void Withdraw(double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException("Depoist cannot be negative.");
            }
            Balance -= value + 5;
        }

        public override string ToString()
        {
            return "Conta "
                + Number
                + ", Titular: "
                + Holder
                + ", Saldo: $ "
                + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}