// Exercicio proposto:

// Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por 
// hora e calcular o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com
// duas casas decimais.

using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, workedHours;
            double valueHours, salary;

            number = int.Parse(Console.ReadLine());
            workedHours = int.Parse(Console.ReadLine());
            valueHours = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salary = valueHours * workedHours;

            Console.WriteLine($"NUMBER = {number}");
            Console.WriteLine("SALARY = U$ " + salary.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
