﻿// Exercicio proposto:
// 
// Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do
// titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. Este valor de depósito
// inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro a depositar no momento de abrir sua
// conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.
// Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado.
// Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).
// Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso.
// O saldo só aumenta por meio de depósitos, e só diminui por meio de saques.
// Para cada saque realizado, o banco cobra uma taxa de $ 5.00.
// Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.
// Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado
// o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação. 

using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o numero da conta: ");
            int codigo = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá deposito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine());

            ContaBancaria cliente = new ContaBancaria(codigo, nome);

            if (depositoInicial == 's' || depositoInicial == 'S')
            {
                Console.Write("Entre com o valor do deposito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                cliente = new ContaBancaria(codigo, nome, valorDepositoInicial);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.EntradaDinheiro(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);

            Console.WriteLine();
            Console.Write("Entre com um valor para retirada: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            cliente.SaidaDinheiro(saque);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(cliente);
        }
    }
}
