﻿// Exercicio proposto:
//
// Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
// um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel4.Fim).
// Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código
// (até que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
// mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível.

using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipo, alcool = 0, gasolina = 0, diesel = 0;

            tipo = int.Parse(Console.ReadLine());

            while (tipo != 4)
            {
                if (tipo == 1)
                {
                    alcool++;
                }
                else if (tipo == 2)
                {
                    gasolina++;
                }
                else if (tipo == 3)
                {
                    diesel++;
                }

                tipo = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("MuITO OBRIGADO!");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");
        }
    }
}
