﻿// Exercicio proposto:
//
// Fazer um programa para ler os valores da largura e altura de um retângulo.
// Em seguida, mostrar na tela o valor de sua área, perímetro e diagonal.
// Usar uma classe como mostrado no projeto ao lado (UML).

using System;
using System.Globalization;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo ret = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo:");
            ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("AREA = " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
