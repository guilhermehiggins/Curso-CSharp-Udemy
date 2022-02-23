// Exercicio proposto:
//
// Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
// começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.

using System;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int duracao;

            string[] vet = Console.ReadLine().Split(' ');
            int x = int.Parse(vet[0]);
            int y = int.Parse(vet[1]);

            if (x < y)
            {
                duracao = y - x;
            }
            else
            {
                duracao = 24 + y - x;
            }

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}
