// Exercicio proposto:
//
// Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários.
// Não deve haver repetição de id. Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
// Para isso, o programa deve ler um id e o valor X. Se o id informado não existir, mostrar uma
// mensagem e abortar a operação.Ao final, mostrar a listagem atualizada dos funcionários.
// Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente.
// Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

using System;
using System.Globalization;
using System.Collections.Generic;

namespace Exercise1List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employeesList = new List<Employee>();

            Console.Write("How many employees will be registred? ");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Employee #{i + 1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine();

                employeesList.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase: ");
            int idIncrease = int.Parse(Console.ReadLine());
            Employee emp = employeesList.Find(x => x.Id == idIncrease);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine();
            Console.WriteLine("Update list of employees:");
            foreach (Employee emp2 in employeesList)
            {
                Console.WriteLine($"{emp2.Id}, {emp2.Name}, " + emp2.Salary.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
