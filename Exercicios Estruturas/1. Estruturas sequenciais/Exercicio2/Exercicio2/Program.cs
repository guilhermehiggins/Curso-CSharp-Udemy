// Exercicio proposto:

// Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo
// com quatro casas decimais.


using System;
using System.Globalization;


namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = 3.14159 * Math.Pow(raio, 2.0);

            Console.WriteLine("A = " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
