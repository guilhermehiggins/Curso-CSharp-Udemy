// Exercicio proposto
//
// Faça um programa para ler a cotação do dólar, e depois um valor em dólares a ser comprado por uma pessoa em reais.
// Informar quantos reais a pessoa vai pagar pelos dólares, considerando ainda que a pessoa terá que pagar 6% de IOF
// sobre o valor em dólar.

using System;
using System.Globalization;

namespace Exercicio6StaticMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantos dólares você vai comprar? ");
            double qtdDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.Valor(cotacao, qtdDolar);

            Console.WriteLine("Valor a ser pagos em reais: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
