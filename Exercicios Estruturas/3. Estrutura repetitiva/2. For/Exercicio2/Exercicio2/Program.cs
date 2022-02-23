// Exercicio proposto:
//
// Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
// Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
// essas informações utilizando a palavra "in" para dentro do intervalo, e "out" para fora do intervalo.

using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos valores serão digitados? ");
            int N = int.Parse(Console.ReadLine());

            int fora = 0, dentro = 0;

            for (int i = 1; i <= N; i++)
            {
                int x = int.Parse(Console.ReadLine());

                if (x < 10 || x > 20)
                {
                    fora++;
                }
                else
                {
                    dentro++;
                }
            }

            Console.WriteLine();
            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
