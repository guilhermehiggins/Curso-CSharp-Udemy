// Exercicio proposto:
//
// Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
// seguir, calcule e mostre o valor da conta a pagar.
//
// Código |    Especificação     |   Preço
//
//   1    | Cachorro quente      | R$ 4.00
//   2    | X-Salada             | R$ 4.50
//   3    | X-Bacon              | R$ 5.00    
//   4    | Torrada Simples      | R$ 2.00
//   5    | Rerigerante          | RS 1.50

using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalVenda;

            Console.Write("Digite o código do produto e a quantidade logo em seguida: ");
            string[] vet = Console.ReadLine().Split(' ');
            int codigo = int.Parse(vet[0]);
            int quantidade = int.Parse(vet[1]);

            if (codigo == 1)
            {
                totalVenda = 4.00 * quantidade;
            }
            else if (codigo == 2)
            {
                totalVenda = 4.50 * quantidade;
            }
            else if (codigo == 3)
            {
                totalVenda = 5.00 * quantidade;
            }
            else if (codigo == 4)
            {
                totalVenda = 2.00 * quantidade;
            }
            else
            {
                totalVenda = 1.50 * quantidade;
            }

            Console.WriteLine("Total: R$ " + totalVenda.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
