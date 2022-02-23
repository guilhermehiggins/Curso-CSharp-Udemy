// Exercicio proposto:
//
// Fazer um programa para ler os dados de um funcionário (nome, salário bruto e imposto).
// Em seguida, mostrar os dados do funcionário (nome e salário líquido). Em seguida, aumentar o salário
// do funcionário com base em uma porcentagem dada (somente o salário bruto é afetado pela porcentagem)
// e mostrar novamente os dados do funcionário. Use a classe projetada abaixo (UML).

using System;
using System.Globalization;

namespace Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();


            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + f1);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f1.AumentarSalario(porcent);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + f1);
        }
    }
}
