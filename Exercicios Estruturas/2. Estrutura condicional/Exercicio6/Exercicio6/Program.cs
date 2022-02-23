// Exercicio proposto
//
// Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos seguintes
// intervalos([0,25], (25,50], (50, 75], (75, 100]) este valor se encontra. Obviamente se o valor não estiver em
// nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.

using System;
using System.Globalization;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um valor: ");
            string[] valor = Console.ReadLine().Split(' ');
            double x = double.Parse(valor[0], CultureInfo.InvariantCulture);

            if(x < 0 || x > 100)
            {
                Console.WriteLine("Fora de intervalo");
            }
            else if (x <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(x <= 50)
            {
                Console.WriteLine("Intervalo [25,50]");
            }
            else if(x <= 75)
            {
                Console.WriteLine("Intervalo [50,75");
            }
            else
            {
                Console.WriteLine("Intervalo [75,100]");
            }
        }
    }
}
