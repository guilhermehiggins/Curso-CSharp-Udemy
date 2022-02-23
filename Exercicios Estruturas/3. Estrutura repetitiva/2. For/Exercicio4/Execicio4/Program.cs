// Exercicio proposto:
//
// Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
// segundo.Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".

using System;
using System.Globalization;

namespace Execicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantas divisões serão feitas? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int numerador = int.Parse(valores[0]);
                int denominador = int.Parse(valores[1]);

                if (denominador == 0)
                {
                    Console.WriteLine("Divisão impossivel");
                }
                else
                {
                    double div = (double)numerador / denominador;
                    Console.WriteLine(div.ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
