// Exercicio proposto:
//
// Fazer um programa para ler os dados de uma conta bancária e depois realizar um saque nesta conta bancária,
// mostrando o novo saldo. Um saque não pode ocorrer ou se não houver saldo na conta,
// ou se o valor do saque for superior ao limite de saque da conta. 

using System;
using System.Globalization;
using Exceções.Entities;
using Exceções.Entities.Exceptions;

namespace Exceções
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter account data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Inicial balance: ");
            double inicialBalance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Account account = new Account(number, holder, inicialBalance, withdrawLimit);

            Console.WriteLine();
            Console.Write("Enter the amount for withdraw: ");
            double withdraw = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(withdraw);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", CultureInfo.InvariantCulture)}");
            }
            catch (DomainException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
