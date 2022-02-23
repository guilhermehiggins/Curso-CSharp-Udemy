// Exercicio proposto:
//
// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
// que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
// qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.
// Leia um valor com duas casas decimais, equivalente ao salário de uma pessoa de Lisarb. Em seguida, calcule e
// mostre o valor que esta pessoa deve pagar de Imposto de Renda, segundo a tabela abaixo.
//
// |          Renda                |    Imposto de Renda
// | de 0.00 a R$ 2000.00          |          Isento
// | de R$ 2000.01 a R$ 3000.00    |            8%
// | de R$ 3000.01 a 4500.00       |           18%
// | acima de R$ 4500.00           |           28%

using System;
using System.Globalization;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, impostoRenda = 0, primeiraFaixa = 0, segundaFaixa = 0, terceiraFaixa = 0;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else
            {
                double baseCalculo = salario - 2000.00;

                if (salario <= 3000.00)
                {
                    impostoRenda = baseCalculo * 0.08;
                }
                else if (salario <= 4500)
                {
                    primeiraFaixa = 1000.00 * 0.08;
                    segundaFaixa = (baseCalculo - 1000) * 0.18;
                }
                else
                {
                    primeiraFaixa = 1000.00 * 0.08;
                    segundaFaixa = 1500.00 * 0.18;
                    terceiraFaixa = (baseCalculo - 2500) * 0.28;
                }

                impostoRenda = primeiraFaixa + segundaFaixa + terceiraFaixa;
                Console.WriteLine("R$ = " + impostoRenda.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}