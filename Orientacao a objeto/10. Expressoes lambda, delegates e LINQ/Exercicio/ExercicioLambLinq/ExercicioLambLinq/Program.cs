// Exercicio proposto:
//
// Fazer um programa para ler os dados (nome, email e salário) de funcionários a partir de um arquivo em formato .csv.
// Em seguida mostrar, em ordem alfabética, o email dos funcionários cujo salário seja superior a um dado valor
// fornecido pelo usuário. Mostrar também a soma dos salários dos funcionários cujo nome começa com a letra 'M'.

using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ExercicioLambLinq.Entities;

namespace ExercicioLambLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter full file path: ");
            string path = Console.ReadLine();

            Console.Write("Enter salary: ");
            double salarySearch = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<Employee> employeesList = new List<Employee>();

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(",");
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employeesList.Add(new Employee(name, email, salary));
                }

                var emails = employeesList.Where(e => e.Salary > salarySearch).OrderBy(e => e.Email).Select(e => e.Email);

                var sum = employeesList.Where(e => e.Name[0] == 'M').Sum(e => e.Salary);

                Console.WriteLine($"Email of people whose salary is more than {salarySearch.ToString("F2", CultureInfo.InvariantCulture)}:");
                foreach (string emp in emails)
                {
                    Console.WriteLine(emp);
                }

                Console.WriteLine("Sum of salary of people whose name starts with 'M': " + sum.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
