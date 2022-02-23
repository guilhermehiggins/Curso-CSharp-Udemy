// Exercicio proposto:
//
// Fazer um programa para ler os dados de N contribuintes (N fornecido pelo usuário), os quais podem ser
// pessoa física ou pessoa jurídica, e depois mostrar o valor do imposto pago por cada um,
// bem como o total de imposto arrecadado.
//
// Os dados de pessoa física são: nome, renda anual e gastos com saúde.
// Os dados de pessoa jurídica são nome, renda anual e número de funcionários. As regras para cálculo de imposto são as seguintes:
// Pessoa física: pessoas cuja renda foi abaixo de 20000.00 pagam 15% de imposto.
// Pessoas com renda de 20000.00 em diante pagam 25% de imposto. Se a pessoa teve gastos com saúde, 50% destes gastos são abatidos no imposto.
// Exemplo: uma pessoa cuja renda foi 50000.00 e teve 2000.00 em gastos com saúde, o imposto fica: (50000 * 25 %) - (2000 * 50 %) = 11500.00
// Pessoa jurídica: pessoas jurídicas pagam 16% de imposto. Porém, se a empresa possuir mais de 10 funcionários, ela paga 14% de imposto.
// Exemplo: uma empresa cuja renda foi 400000.00 e possui 25 funcionários, o imposto fica: 400000 * 14 % = 56000.00

using System;
using System.Globalization;
using Abstratos.Entities;
using System.Collections.Generic;

namespace Abstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayer> list = new List<Taxpayer>();

            Console.Write("Enter the number of taxpayers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or Company (i/c)? ");
                char payerType = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (payerType == 'i' || payerType == 'I')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new Individual(name, anualIncome, healthExpend));
                }
                else if (payerType == 'c' || payerType == 'C')
                {
                    Console.Write("Number of employees: ");
                    int employeesNumber = int.Parse(Console.ReadLine());

                    list.Add(new Company(name, anualIncome, employeesNumber));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            foreach (Taxpayer taxpayer in list)
            {
                Console.WriteLine(taxpayer);
            }

            double sum = 0;
            foreach (Taxpayer taxpayer in list)
            {
                sum += taxpayer.TaxesPaid();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: ${sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
