using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bank;
            Console.Write("Entre o número da conta: ");
            int number = int.Parse(Console.ReadLine());


            Console.Write("Entre o titular da conta: ");
            string holder = Console.ReadLine();

            Console.Write("Haverá depósito inicial (S/n)?");
            string question = Console.ReadLine();
            
            if (question != "N" || question != "n")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                bank = new BankAccount(number, holder, balance);
            }
            else {
                bank = new BankAccount(number, holder);
            }

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(bank);

            Console.Write("Entre um valor para depósito: ");
            bank.Deposit(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(bank);

            Console.Write("Entre um valor para saque: ");
            bank.Withdraw(double.Parse(Console.ReadLine()));

            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(bank);
        }
    }
}