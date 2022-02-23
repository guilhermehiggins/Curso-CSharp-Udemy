// Exercicio proposto:
//
// Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
// (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada).
// Ao final, mostrar qual a nota final do aluno no ano.
// Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
// para o aluno obter o mínimo para ser aprovado (que é 60 pontos).

using System;
using System.Globalization;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            aluno.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(aluno);
        }
    }
}
