// Exercicio proposto:
//
// Fazer um programa para ler dois números inteiros M e N, e depois ler uma matriz de M linhas por N colunas
// contendo números inteiros, podendo haver repetições. Em seguida, ler um número inteiro X que pertence à matriz.
// Para cada ocorrência de X, mostrar os valores à esquerda, acima, à direita e abaixo de X, quando houver.

using System;

namespace ExercicioMatriz2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] matriz = Console.ReadLine().Split(" ");
            int M = int.Parse(matriz[0]);
            int N = int.Parse(matriz[1]);

            int[,] mat = new int[M, N];

            for (int i = 0; i < M; i++)
            {
                string[] values = Console.ReadLine().Split(" ");

                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (x == mat[i, j])
                    {
                        Console.WriteLine($"Position: {i},{j}");

                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {mat[i, j - 1]}");
                        }

                        if (j + 1 < N)
                        {
                            Console.WriteLine($"Rigth: {mat[i, j + 1]}");
                        }

                        if (i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {mat[i - 1, j]}");
                        }

                        if (i + 1 < M)
                        {
                            Console.WriteLine($"Down: {mat[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
