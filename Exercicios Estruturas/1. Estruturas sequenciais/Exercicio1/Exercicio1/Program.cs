// Exercicio proposto:

//  Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números.

using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, soma = 0;

            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            soma = x + y;

            Console.WriteLine($"SOMA = {soma}");
        }
    }
}
