// Exercicio proposto:
//
// Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou
// "Nao sao Multiplos ", indicando se os valores lidos são múltiplos entre si.
// Atenção: os números devem poder ser digitados em ordem crescente ou decrescente.


using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe os valores: ");
            string[] vet = Console.ReadLine().Split(' ');
            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("SÃO MULTIPLOS");
            }
            else
            {
                Console.WriteLine("NÃO SÂO MULTIPLOS");
            }
        }
    }
}
