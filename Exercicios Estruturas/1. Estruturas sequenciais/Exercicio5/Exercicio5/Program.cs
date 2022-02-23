// Exercicio proposto:

// Fazer um programa para ler (em uma mesma linha) o código de uma peça 1, o número de peças 1, o valor unitário
// de cada peça 1, o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2.
// Calcule e mostre o valor a ser pago.

using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {

            int codigo1, codigo2, pecas1, pecas2;
            double valor1, valor2, totalCompra;

            Console.Write("Dados peça 1: ");
            string[] vet1 = Console.ReadLine().Split(' ');
            codigo1 = int.Parse(vet1[0]);
            pecas1 = int.Parse(vet1[1]);
            valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            Console.Write("Dados peça 2: ");
            string[] vet2 = Console.ReadLine().Split(' ');
            codigo2 = int.Parse(vet2[0]);
            pecas2 = int.Parse(vet2[1]);
            valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            totalCompra = pecas1 * valor1 + pecas2 * valor2;

            Console.WriteLine("VALOR A PAGAR = R$ " + totalCompra.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
