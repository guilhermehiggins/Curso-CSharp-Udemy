// Exercicio proposto:

// Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a
// diferença do produto de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).

using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, diferenca;

            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());

            diferenca = A * B - C * D;

            Console.WriteLine($"DIFERENÇA = {diferenca}");
        }
    }
}
